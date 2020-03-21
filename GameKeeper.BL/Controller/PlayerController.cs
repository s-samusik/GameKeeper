using GameKeeper.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GameKeeper.BL.Controller
{
    public class PlayerController : BaseController
    {
        public delegate void Counter();

        public event Counter OnRespawn;

        private const string PLAYERS_FILE_NAME = "Players.dat";

        #region Properties

        /// <summary>
        /// List of players.
        /// </summary>
        public List<Player> Players { get; set; }

        /// <summary>
        /// Current player.
        /// </summary>
        public Player CurrentPlayer { get; set; }

        /// <summary>
        /// Current player is new.
        /// </summary>
        public bool IsCurrentPlayerNew { get; set; } = false;

        /// <summary>
        /// Punishment for death current player.
        /// </summary>
        public double Punishment { get; set; }
        #endregion

        #region Constructors
        public PlayerController(string playerId)
        {
            #region Verification of conditions
            if (string.IsNullOrWhiteSpace(playerId))
            {
                throw new ArgumentException("Id игрока не можеть быть Null", nameof(playerId));
            }
            #endregion

            Players = GetPlayersData();

            CurrentPlayer = Players.SingleOrDefault(p => p.Id == playerId);

            if (CurrentPlayer == null)
            {
                CurrentPlayer = new Player(playerId);
                Players.Add(CurrentPlayer);
                IsCurrentPlayerNew = true;
            }
        }
        #endregion

        /// <summary>
        /// Get list players of current game or create new list.
        /// </summary>
        /// <returns>List players.</returns>
        private List<Player> GetPlayersData()
        {
            return Load<List<Player>>(PLAYERS_FILE_NAME) ?? new List<Player>();
        }

        /// <summary>
        /// Save current list players to file.
        /// </summary>
        public void SavePlayersData()
        {
            Save(PLAYERS_FILE_NAME, Players);
        }

        /// <summary>
        /// Create new player for current game.
        /// </summary>
        /// <param name="nickname">Player's nickname.</param>
        /// <param name="groupingName">Name of grouping.</param>
        /// <param name="pincode">4 digits pincode.</param>
        /// <param name="cash">Start cash.</param>
        public void SetNewPlayerData(string nickname, string groupingName, string pincode, double cash = 0)
        {
            #region Verification of conditions
            if (string.IsNullOrWhiteSpace(nickname))
            {
                throw new ArgumentException("Никнейм обязателен.", nameof(nickname));
            }

            if (string.IsNullOrWhiteSpace(groupingName))
            {
                throw new ArgumentNullException("Группировка обязательна.", nameof(groupingName));
            }

            if (string.IsNullOrWhiteSpace(pincode))
            {
                throw new ArgumentNullException("Пинкод обязателен.", nameof(pincode));
            }

            if (cash < 0)
            {
                throw new ArgumentException("Стартовый капитал не может быть меньше нуля.", nameof(cash));
            }
            #endregion

            CurrentPlayer.NickName = nickname;
            CurrentPlayer.PinCode = pincode;
            CurrentPlayer.Grouping = new Grouping(groupingName);
            CurrentPlayer.Cash = cash;

            SavePlayersData();
        }

        /// <summary>
        /// Create pincode for new player.
        /// </summary>
        /// <returns>4 digits pincode.</returns>
        public string CreatePincode()
        {
            Random rnd = new Random();
            string result = string.Format("{0:d4}", rnd.Next(0, 9999));

            return result;
        }

        /// <summary>
        /// Delete current player from this game.
        /// </summary>
        /// <param name="currentPlayer">Current player in game.</param>
        public void DelCurrentPlayer()
        {
            Players.Remove(CurrentPlayer);
            SavePlayersData();
        }

        /// <summary>
        /// Return current state of player.
        /// </summary>
        /// <returns>Player's state.</returns>
        public string ReturnPlayerState()
        {
            if (CurrentPlayer.IsDead)
            {
                return $"killed. Time left: {TimeSpan.FromSeconds(CurrentPlayer.DeadTimeInSecond).ToString(@"hh\:mm\:ss")}";
            }
            return "alive";
        }

        /// <summary>
        /// Dead time of current player.
        /// </summary>
        /// <returns></returns>
        public async Task DeadTimeAsync()
        {
            await Task.Run(() => TimeCounter());
            CurrentPlayer.IsDead = false;
            OnRespawn();
            SavePlayersData();
        }

        /// <summary>
        /// Put fine for death current player.
        /// </summary>
        /// <param name="punishment">size of punishment</param>
        /// <returns>True if the punishment is applied.</returns>
        public bool PutPunishmentForDeath(string punishment)
        {
            if (!string.IsNullOrEmpty(punishment)) Punishment = double.Parse(punishment);

            if (CurrentPlayer.Cash < Punishment) return false;

            CurrentPlayer.Cash -= Punishment;
            SavePlayersData();

            return true;
        }

        /// <summary>
        /// Counter dead time of current player.
        /// </summary>
        private void TimeCounter()
        {
            while (CurrentPlayer.DeadTimeInSecond > 0)
            {
                CurrentPlayer.DeadTimeInSecond--;
                Thread.Sleep(1000);
            }
        }
    }
}
