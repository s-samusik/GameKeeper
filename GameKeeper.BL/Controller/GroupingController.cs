using GameKeeper.BL.Model;
using System.Collections.Generic;

namespace GameKeeper.BL.Controller
{
    public class GroupingController : BaseController
    {
        private const string GROUPING_FILE_NAME = "Groupings.dat";
        private const string DEFAULT_GROUPING = "none";

        #region Properties
        /// <summary>
        /// This grouping is assigned to all new players.
        /// </summary>
        public Grouping DefaultGrouping { get; } = new Grouping(DEFAULT_GROUPING);

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

            if (Groupings.Count == 0)
            {
                Groupings.Add(DefaultGrouping);
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
        /// <returns>Is this grouping has been deleted.</returns>
        public bool DelSelectedGrouping(int index)
        {
            if (index != 0)
            {
                Groupings.RemoveAt(index);
                SaveAllGroupings();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Delete all groupings in current game.
        /// </summary>
        public void DelAllGroupings()
        {
            Groupings.Clear();
            Groupings.Add(DefaultGrouping);
            SaveAllGroupings();
        }
        
        /// <summary>
        /// Is grouping already exist.
        /// </summary>
        /// <param name="groupingName">Name of new grouping.</param>
        /// <returns>Is grouping found.</returns>
        public bool IsGroupingAlreadyExists(string groupingName)
        {
            foreach (var item in Groupings)
            {
                if (item.Name == groupingName) return true;
            }
            return false;
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
