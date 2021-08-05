using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }

        public Hunter(string fName, string lName, IShootable shooter) : base (fName, lName)
        {
            Shooter = shooter;
        }

        public Hunter()
        {
            // empty constructor
        }

        public string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {Shooter}";
        }
    }
}
