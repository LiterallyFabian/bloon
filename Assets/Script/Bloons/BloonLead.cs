namespace Bloonz.Bloons
{
    public class BloonLead : Bloon
    {
        public override string Name => "Lead";
        public override int Health => 1;
        public override int Value => 23;
        public override float Speed => 1.0f;
        public override Bloon[] Children => new Bloon[] { new BloonBlack(), new BloonBlack() };
        public override DamageType[] Immunities => new DamageType[] { DamageType.Sharpness};
        public override bool Camo => false;
    }
}