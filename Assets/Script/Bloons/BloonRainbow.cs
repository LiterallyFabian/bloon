using System;

namespace Bloonz.Bloons
{
    public class BloonRainbow : Bloon
    {
        public override string Name => "Rainbow";
        public override int Health => 1;
        public override int Value => 47;
        public override float Speed => 2.2f;
        public override Bloon[] Children => new Bloon[] { new BloonZebra(), new BloonZebra() };
        public override DamageType[] Immunities => Array.Empty<DamageType>();
        public override bool Camo => false;
    }
}