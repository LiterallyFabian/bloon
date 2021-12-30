using System;

namespace Bloonz.Bloons
{
    public class BloonYellow : Bloon
    {
        public override string Name => "Yellow";
        public override int Health => 1;
        public override int Value => 4;
        public override float Speed => 3.2f;
        public override Bloon[] Children => new Bloon[] { new BloonGreen() };
        public override DamageType[] Immunities => Array.Empty<DamageType>();
        public override bool Camo => false;
    }
}