using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
            // empty method
        }

        public override string Shoot()
        {
            return $" Splash!! {base.Shoot()}";
        }
    }
}
