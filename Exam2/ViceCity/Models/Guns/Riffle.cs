using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Riffle : Gun, IGun
    {
        private const int bulletsPerBarrel = 10;
        private const int totalBullets = 100;
        private const int numberOfBulletsthatShot = 1;

        public Riffle(string name)
            : base(name, bulletsPerBarrel, totalBullets)
        {
        }

        public override int Fire()
        {
            if (!this.CanFire)
            {
                return 0;
            }

            this.BulletsPerBarrel -= numberOfBulletsthatShot;
            return numberOfBulletsthatShot;
        }
    }
}
