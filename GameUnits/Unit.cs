using System;

namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public virtual int Health { get; protected set; }

        public virtual float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(int distance)
        {
            Console.WriteLine($"A unidade moveu {distance} casas.");
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost:F2}";
        }
    }
}


