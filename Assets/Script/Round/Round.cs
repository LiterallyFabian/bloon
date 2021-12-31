using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Bloonz.Round
{
    public class Round
    {
        /// <summary>
        /// All groups of bloons this round will spawn.
        /// </summary>
        public BloonGroup[] BloonGroups { get; private set; }
        
        /// <summary>
        /// Total amount of bloons this round will spawn.
        /// </summary>
        public int TotalBloons { get; private set; }
        
        public Round(BloonGroup[] bloonGroups)
        {
            BloonGroups = bloonGroups;
            
            foreach (BloonGroup group in BloonGroups)
            {
                TotalBloons += group.Count;
            }
        }
    }
}