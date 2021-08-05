using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    class Weapon : IShootable
    {
        // fields
        private string _brand;

        // methods
        public virtual string Shoot()
        {
            return $" Shooting a {ToString()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }

        public Weapon(string brand)
        {
            _brand = brand;
        }
    }
}
