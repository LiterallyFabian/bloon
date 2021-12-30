using System;

namespace Bloonz.Bloons
{
    public class BloonGreen : Bloon
    {
        public override string Name => "Green";
        public override int Health => 1;
        public override int Value => 3;
        public override float Speed => 1.8f;
        public override Bloon[] Children => new Bloon[] { new BloonBlue() };
        public override DamageType[] Immunities => Array.Empty<DamageType>();
        public override bool Camo => false;
    }
}