using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun, IGun
    {
        private const int bulletsPerBarrel = 10;
        private const int totalBullets = 100;
        private const int numberOfBulletsthatShot = 1;

        public Pistol(string name)
            : base(name, bulletsPerBarrel, totalBullets)
        {
        }

        public override int Fire()
        {
           
            if (this.BulletsPerBarrel <= 0)
            {
                if(!this.CanFire)
                    return 0;

                this.Reload();
            }

            this.BulletsPerBarrel -= numberOfBulletsthatShot;
            return numberOfBulletsthatShot;
        }
    }
}
