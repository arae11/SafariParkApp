using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;

        public int NumPassengers
        {
            get
            {
                return _numPassengers;
            }
            set
            {
                if (value < _capacity && value > 0)
                {
                    _numPassengers = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("You have too many or too few passengers!");
                }
            }
        }
        public int Position { get; private set; }
        public int Speed { get; init; }

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * Speed;
            return $"Moving along {Position} times";
        }

        public Vehicle()
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }
    }
}
