using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {
            // empty method
        }

        public override string Shoot()
        {
            return $" Zing!! {base.Shoot()}";
        }
    }
}
