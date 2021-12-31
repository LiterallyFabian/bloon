using UnityEngine;

namespace Bloonz.Round
{
    /// <summary>
    /// Represents a group of bloons spawning in a round.
    /// </summary>
    public class BloonGroup
    {
        /// <summary>
        /// How long the group should wait before spawning the first bloon.
        /// </summary>
        public float Delay { get; set; }
        
        /// <summary>
        /// The type of bloon this group will spawn.
        /// </summary>
        public BloonType BloonType { get; private set; }
        
        /// <summary>
        /// The number of bloons this group will spawn.
        /// </summary>
        public int Count { get; private set; }
        
        /// <summary>
        /// Over how many seconds this group will spawn bloons for.
        /// </summary>
        public float SpawnTime { get; private set; }
        
        /// <summary>
        /// The delay between each bloon in the group.
        /// </summary>
        public float DelayBetweenBloons { get; private set; }

        public BloonGroup(float delay, BloonType bloonType, int count, float spawnTime)
        {
            Delay = delay;
            BloonType = bloonType;
            Count = count;
            SpawnTime = spawnTime;
            DelayBetweenBloons = spawnTime / count;
        }
    }
}