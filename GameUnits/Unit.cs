namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public virutal int Health { get; protected set; }

        public readonly float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(int distancia)
        {
            Console.WriteLine($"A unidade moveu {distancia} casas.");
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost:F2}";
        }
    }
}
