using System;

namespace Bloonz.Bloons
{
    public class BloonPink : Bloon
    {
        public override string Name => "Pink";
        public override int Health => 1;
        public override int Value => 5;
        public override float Speed => 3.5f;
        public override Bloon[] Children => new Bloon[] { new BloonYellow() };
        public override DamageType[] Immunities => Array.Empty<DamageType>();
        public override bool Camo => false;
    }
}