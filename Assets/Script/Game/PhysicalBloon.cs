using UnityEngine;
using Bloonz.Bloons;

namespace Bloonz.Game
{
    /// <summary>
    /// A physical representation of a Bloon in the game.
    /// </summary>
    public class PhysicalBloon : MonoBehaviour
    {
        [Tooltip("The Bloon that this PhysicalBloon represents.")]
        public Bloon Bloon;
        
        public PathFollow PathFollow;
        
        /// <summary>
        /// Changes the Bloon type that this PhysicalBloon represents.
        /// </summary>
        /// <param name="b">The new bloon type to use.</param>
        public void SetBloon(Bloon b)
        {
            Bloon = b;
            GetComponent<SpriteRenderer>().sprite = Bloon.Sprite;
        }
    }
}