using GameKeeper.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameKeeper.BL.Controller
{
    public class PlayerController : BaseController
    {
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
        public void DelCurrentPlayer(Player currentPlayer)
        {
            Players.Remove(currentPlayer);
            SavePlayersData();
        }

        /// <summary>
        /// Put cash in wallet.
        /// </summary>
        /// <param name="cash">Cash amount.</param>
        public void PutInWallet(double cash)
        {
            #region Verification of conditions
            if (cash < 0)
            {
                throw new ArgumentException("Сумма не может быть меньше нуля.", nameof(cash));
            }
            #endregion

            CurrentPlayer.Cash += cash;
            SavePlayersData();
        }

        /// <summary>
        /// Withdraw cash from wallet.
        /// </summary>
        /// <param name="cash">Cash amount.</param>
        /// <returns>The withdraw was successful.</returns>
        public bool WithdrawFromWallet(double cash)
        {
            #region Verification of conditions
            if (cash < 0)
            {
                throw new ArgumentException("Сумма не может быть меньше нуля.", nameof(cash));
            }
            #endregion

            if (CurrentPlayer.Cash >= cash)
            {
                CurrentPlayer.Cash -= cash;
                SavePlayersData();
                return true;
            }
            return false;
        }
    }
}
