using System;
using System.Collections.Generic;
using UnityEngine;

namespace Bloonz.Bloons
{
    /// <summary>
    /// Creates static instances of bloons with pre-defined properties and pre-loaded sprites.
    /// </summary>
    public class Manager : MonoBehaviour
    {
        public static Manager Instance;
        private Bloon[] _bloons;
        
        private void Start()
        {
            Instance = this;
            InitializeBloons();
        }

        private void InitializeBloons()
        {
            List<Bloon> bloons = new List<Bloon>();
            foreach (BloonType bloonType in (BloonType[]) Enum.GetValues(typeof(BloonType)))
            {
                Type type = Type.GetType($"Bloonz.Bloons.Bloon{bloonType}");
                Bloon bloon = (Bloon)Activator.CreateInstance(type);
                bloon.Sprite = Resources.Load<Sprite>($"Bloons/{bloonType}");
                bloons.Add(bloon);
            }
            _bloons = bloons.ToArray();
        }
        
        public static Bloon GetBloon(BloonType type)
        {
            return Instance._bloons[(int) type];
        }
        
        
    }
    
}