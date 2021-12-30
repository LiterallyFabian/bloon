namespace Bloon.Bloons
{
    public class BloonWhite : Bloon
    {
        public override string Name => "White";
        public override int Health => 1;
        public override int Value => 11;
        public override float Speed => 2.0f;
        public override Bloon[] Children => new Bloon[] { new BloonPink(), new BloonPink() };
        public override DamageType[] Immunities => new DamageType[] { DamageType.Ice};
        public override bool Camo => false;
    }
}