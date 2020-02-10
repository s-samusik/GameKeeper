using GameKeeper.BL.Model;
using System;
using System.IO;

namespace GameKeeper.BL.Controller
{
    public class GameController : BaseController
    {
        private const string GAME_FILE_NAME = "CurrentGame.dat";
        private const string GAME_FILE_TYPE = "*.dat";

        #region Properties
        /// <summary>
        /// Current game.
        /// </summary>
        public Game CurrentGame { get; }

        /// <summary>
        /// The current game is new.
        /// </summary>
        public bool IsGameNew { get; } = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Load current game.
        /// </summary>
        public GameController()
        {
            CurrentGame = GetGameData();

            if (CurrentGame == null)
            {
                IsGameNew = true;
            }
        }

        /// <summary>
        /// Create new game.
        /// </summary>
        /// <param name="name">Name of game.</param>
        /// <param name="password">Password of game.</param>
        public GameController(string name, string password)
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

            CurrentGame = new Game(name, password);

            SaveGameData();
        }
        #endregion

        /// <summary>
        /// Delete all files of current game.
        /// </summary>
        /// <param name="path">game file location</param>
        public void DeleteCurrentGame(string path)
        {
            string[] files = Directory.GetFiles(path, GAME_FILE_TYPE);

            foreach (string file in files)
            {
                File.Delete(file);
            }
        }

        /// <summary>
        /// Get current game from file.
        /// </summary>
        /// <returns>Return current game.</returns>
        private Game GetGameData()
        {
            return Load<Game>(GAME_FILE_NAME);
        }

        /// <summary>
        /// Save current game to file.
        /// </summary>
        private void SaveGameData()
        {
            Save(GAME_FILE_NAME, CurrentGame);
        }
    }
}
