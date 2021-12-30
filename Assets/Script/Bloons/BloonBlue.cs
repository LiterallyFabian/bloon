using System;

namespace Bloonz.Bloons
{
    public class BloonBlue : Bloon
    {
        public override string Name => "Blue";
        public override int Health => 1;
        public override int Value => 1;
        public override float Speed => 1.4f;
        public override Bloon[] Children => new Bloon[] { new BloonRed() };
        public override DamageType[] Immunities => Array.Empty<DamageType>();
        public override bool Camo => false;
    }
}