using System;

namespace GameKeeper.BL.Model
{
    [Serializable]
    public class Game
    {
        #region Properties
        /// <summary>
        /// Name of current game.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Password of current game.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Start's time current game.
        /// </summary>
        public DateTime StartTime { get; set; }
        #endregion

        /// <summary>
        /// Create new game.
        /// </summary>
        /// <param name="name">Name of current game.</param>
        /// <param name="password">Password of current game.</param>
        public Game(string name, string password)
        {
            #region Verification of conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название игры не может быть пустым или null", nameof(name));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Пароль не может быть пустым или null", nameof(password));
            }
            #endregion

            Name = name;
            Password = password;
            StartTime = DateTime.Now;
        }
    }
}
