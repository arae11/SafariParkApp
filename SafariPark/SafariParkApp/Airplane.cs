using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    class Airplane : Vehicle
    {
        // fields
        private string _airline;

        // properties
        public int Altitude { get; private set; }

        // methods
        public Airplane(int capacity) : base (capacity)
        {
            Speed = 100;
            _airline = "JetsRUs";
        }

        public Airplane(int capacity, int speed, string airline)
        {
            _capacity = capacity;
            Speed = speed;
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            Altitude -= distance;
        }

        public override string Move()
        {
            base.Move();
            return $"Moving along at an altitude of {Altitude} meters.";
        }

        public override string Move(int times)
        {
            base.Move(times);
            return $"Moving along {times} times at an altitude of {Altitude} meters.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {_capacity} passengers: {_numPassengers} speed: {Speed} position: {Position} altitude: {Altitude}.";
        }
    }
}
