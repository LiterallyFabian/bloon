using Bloonz.Game;

namespace Bloonz.Towers
{
    public class TowerTackShooter : Tower
    {
        public override string Name { get; set; } = "Tack Shooter";
        public override int Cost { get; set; } = 280;
        public override float Range { get; set; } = 3.5f;
        public override float FireRate { get; set; } = 0.5f;
        public override Upgrade[] Upgrades { get; set; }
        public override bool CanSeeCamo { get; set; } = false;

        protected override void Attack(PhysicalBloon bloon)
        {
            throw new System.NotImplementedException();
        }
    }
}