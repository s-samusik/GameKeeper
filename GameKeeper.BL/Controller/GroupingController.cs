using GameKeeper.BL.Model;
using System.Collections.Generic;

namespace GameKeeper.BL.Controller
{
    public class GroupingController : BaseController
    {
        private const string GROUPING_FILE_NAME = "Groupings.dat";

        #region Properties
        /// <summary>
        /// List of groupings.
        /// </summary>
        public List<Grouping> Groupings { get; }
        #endregion

        #region Constructors
        /// <summary>
        /// Load or create list of groupings. 
        /// </summary>
        public GroupingController()
        {
            Groupings = GetAllGroupings();

            if (Groupings == null)
            {
                Groupings = new List<Grouping>();
            }

            SaveAllGroupings();
        }
        #endregion

        /// <summary>
        /// Add new grouping into game and save to file.
        /// </summary>
        /// <param name="name">Name of grouping.</param>
        public void AddGrouping(string name)
        {
            Grouping grouping = new Grouping(name);
            Groupings.Add(grouping);
            SaveAllGroupings();
        }

        /// <summary>
        /// Delete selected grouping in current game.
        /// </summary>
        /// <param name="index">Index of the item to be deleted.</param>
        public void DelSelectedGrouping(int index)
        {
            Groupings.RemoveAt(index);
            SaveAllGroupings();
        }

        /// <summary>
        /// Delete all groupings in current game.
        /// </summary>
        public void DelAllGroupings()
        {
            Groupings.Clear();
            SaveAllGroupings();
        }
        
        /// <summary>
        /// Get current list of grouping from file.
        /// </summary>
        /// <returns>Return list of grouping.</returns>
        private List<Grouping> GetAllGroupings()
        {
            return Load<List<Grouping>>(GROUPING_FILE_NAME);
        }

        /// <summary>
        /// Save current list of grouping to file.
        /// </summary>
        private void SaveAllGroupings()
        {
            Save(GROUPING_FILE_NAME, Groupings);
        }
    }
}
