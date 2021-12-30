using UnityEngine;

namespace Bloonz.Bloons
{
    public class BloonBlack : Bloon
    {
        public override BloonType Type => BloonType.Black;
        public override int Health => 1;
        public override int Value => 11;
        public override float Speed => 1.8f;
        public override Bloon[] Children => new Bloon[] { new BloonPink(), new BloonPink() };
        public override DamageType[] Immunities => new DamageType[] { DamageType.Explosive };
        public override bool Camo => false;
    }
}