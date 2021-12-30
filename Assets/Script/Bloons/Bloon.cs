using UnityEngine;

namespace Bloonz.Bloons
{
    /// <summary>
    /// A container for a Bloon's stats.
    /// </summary>
    public abstract class Bloon
    {
        /// <summary>
        /// The type of bloon.
        /// </summary>
        public abstract BloonType Type { get; }
        
        /// <summary>
        /// The health of the Bloon.
        /// </summary>
        public abstract int Health { get; }
        
        /// <summary>
        /// Amount of cash the Bloon is worth.
        /// </summary>
        public abstract int Value { get; }
        
        /// <summary>
        /// Speed modifier at which the Bloon moves.
        /// </summary>
        public abstract float Speed { get; }
        
        /// <summary>
        /// Bloons summoned when this Bloon is popped.
        /// </summary>
        public abstract Bloon[] Children { get; }
        
        /// <summary>
        /// What this bloon is immune to.
        /// </summary>
        public abstract DamageType[] Immunities { get; }
        
        /// <summary>
        /// Whether or not this Bloon is camouflaged.
        /// </summary>
        public abstract bool Camo { get; }
        
        /// <summary>
        /// The sprite of this Bloon.
        /// </summary>
        public Sprite Sprite { get; set; }
    }
}