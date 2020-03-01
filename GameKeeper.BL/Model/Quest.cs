using System;

namespace GameKeeper.BL.Model
{
    [Serializable]
    public class Quest
    {
        #region Properties
        /// <summary>
        /// Quest's name. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Quest's description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Life time of quest.
        /// </summary>
        public DateTime LifeTime { get; set; }
 
        /// <summary>
        /// Reward from completed quest.
        /// </summary>
        public double Reward { get; set; }

        /// <summary>
        /// Punishment from uncompleted quest.
        /// </summary>
        public double Punishment { get; set; }

        public bool IsCompleted { get; set; } = false;
        #endregion

        /// <summary>
        /// Create new quest.
        /// </summary>
        /// <param name="name">Quest's name.</param>
        /// <param name="description">Quest's description.</param>
        /// <param name="lifeTime">Life time of quest.</param>
        /// <param name="reward">Reward from completed quest.</param>
        /// <param name="punishment">Punishment from uncompleted quest.</param>
        public Quest(string name, DateTime lifeTime, string description = "", double reward = 0, double punishment = 0)
        {
            #region Verification of conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название квеста не может быть пустым", nameof(name));
            }

            if (lifeTime == null)
            {
                throw new ArgumentException("Время выполнения квеста не может быть null", nameof(lifeTime));
            }

            if (reward < 0)
            {
                throw new ArgumentException("Награда за квест не может быть отрицательной", nameof(reward));
            }

            if (punishment < 0)
            {
                throw new ArgumentException("Наказание за провал квеста не может быть отрицательным", nameof(punishment));
            }
            #endregion

            Name = name;
            Description = description;
            LifeTime = lifeTime;
            Reward = reward;
            Punishment = punishment;
        }
    }
}
