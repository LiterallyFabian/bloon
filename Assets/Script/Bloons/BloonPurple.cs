namespace Bloonz.Bloons
{
    public class BloonPurple : Bloon
    {
        public override BloonType Type => BloonType.Purple;
        public override int Health => 1;
        public override int Value => 11;
        public override float Speed => 3.0f;
        public override Bloon[] Children => new Bloon[] { new BloonPink(), new BloonPink() };
        public override DamageType[] Immunities => new DamageType[] { DamageType.Fire, DamageType.Magical };
        public override bool Camo => false;
    }
}