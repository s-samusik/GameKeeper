using System;

namespace GameKeeper.BL.Model
{
    [Serializable]
    public class Grouping
    {
        #region Properties
        /// <summary>
        /// Name of grouping.
        /// </summary>
        public string Name { get; }
        #endregion

        /// <summary>
        /// Create new grouping.
        /// </summary>
        /// <param name="name">Name of grouping.</param>
        public Grouping(string name)
        {
            #region Verification of conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название группировки обязательно", nameof(name));
            }
            #endregion

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
