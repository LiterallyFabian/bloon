using System;
using System.Collections;
using System.Collections.Generic;
using Bloonz.Game;
using UnityEngine;

namespace Bloonz.Towers
{
    public abstract class Tower : MonoBehaviour
    {
        /// <summary>
        /// The name of this tower
        /// </summary>
        public abstract string Name { get; set;  }

        /// <summary>
        /// The base cost of this tower
        /// </summary>
        public abstract int Cost { get; set; }

        /// <summary>
        /// The base range of this tower
        /// </summary>
        public abstract float Range { get; set; }

        /// <summary>
        /// The base fire rate of this tower
        /// </summary>
        public abstract float FireRate { get; set; }

        /// <summary>
        /// The upgrades available for this tower
        /// </summary>
        public abstract Upgrade[] Upgrades { get; set; }

        /// <summary>
        /// Tries to perform an attack on a target. Called from base.Update() if the tower is ready to attack.
        /// </summary>
        protected abstract void Attack(PhysicalBloon bloon);
        
        /// <summary>
        /// The last time this tower fired
        /// </summary>
        private float _lastAttackTime;

        private void Update()
        {
            if (Time.time - _lastAttackTime > FireRate)
            {
                _lastAttackTime = Time.time;
                PhysicalBloon target = GetFirstInRange();
                if (target != null)
                {
                    Attack(target);
                }
            }
        }

        private PhysicalBloon GetFirstInRange()
        {
            foreach (PhysicalBloon bloon in GameManager.Instance.SortedBloons)
            {
                if(Vector3.Distance(transform.position, bloon.transform.position) <= Range)
                {
                    return bloon;
                }
            }

            return null;
        }
    }
}