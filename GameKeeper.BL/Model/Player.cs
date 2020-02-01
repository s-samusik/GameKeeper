using System;

namespace GameKeeper.BL.Model
{
    [Serializable]
    public class Player
    {
        #region Properties

        /// <summary>
        /// Unique player's ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Player's nickname.
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Player's unique pincode.
        /// </summary>
        public string PinCode { get; set; }

        /// <summary>
        /// Player's grouping.
        /// </summary>
        public Grouping Grouping { get; set; }

        /// <summary>
        /// Player's cash.
        /// </summary>
        public double Cash { get; set; }

        /// <summary>
        /// Date and time of start of the game.
        /// </summary>
        public DateTime GameStart { get; set; }

        /// <summary>
        /// Player's count of deaths.
        /// </summary>
        public int CountOfDeaths { get; set; }

        /// <summary>
        /// Player's count of completed quests.
        /// </summary>
        public int CountOfCompletedQuests { get; set; }

        /// <summary>
        /// Player's count of uncompleted quests.
        /// </summary>
        public int CountOfUncompletedQuests { get; set; }

        /// <summary>
        /// Player's state of life.
        /// </summary>
        public bool IsDead { get; set; }
        #endregion


        /// <summary>
        /// Create new player.
        /// </summary>
        /// <param name="id">Unique player's id.</param>
        public Player(string id)
        {
            #region Verification of conditions
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id обязателен.", nameof(id));
            }
            #endregion

            Id = id;
        }

        /// <summary>
        /// Create new player.
        /// </summary>
        /// <param name="nickname">Player's nickname.</param>
        /// <param name="grouping">Grouping of player.</param>
        /// <param name="cash">Player's cash in start game.</param>
        public Player(string nickname, Grouping grouping, double cash = 0)
        {
            #region Verification of conditions
            if (string.IsNullOrWhiteSpace(nickname))
            {
                throw new ArgumentException("Никнейм обязателен.", nameof(nickname));
            }

            if (grouping is null)
            {
                throw new ArgumentNullException("Группировка не может быть null", nameof(grouping));
            }

            if (cash < 0)
            {
                throw new ArgumentException("Количество денег не может быть отрицательным.", nameof(cash));
            }
            #endregion  

            NickName = nickname;
            Grouping = grouping;
            Cash = cash;
            GameStart = DateTime.Now;
            CountOfDeaths = 0;
            CountOfCompletedQuests = 0;
            CountOfUncompletedQuests = 0;
            IsDead = false;
        }
    }
}
