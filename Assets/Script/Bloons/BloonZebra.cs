namespace Bloonz.Bloons
{
    public class BloonZebra : Bloon
    {
        public override BloonType Type => BloonType.Zebra;
        public override int Health => 1;
        public override int Value => 23;
        public override float Speed => 1.8f;
        public override Bloon[] Children => new Bloon[] { new BloonBlack(), new BloonWhite() };
        public override DamageType[] Immunities => new DamageType[] { DamageType.Ice, DamageType.Explosive };
        public override bool Camo => false;
    }
}