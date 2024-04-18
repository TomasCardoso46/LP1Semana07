namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public SettlerUnit(int attackPower = 0) : base(movement: 1, health: 3)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public override float Cost
        {
            get { return 5; }
        }
    }
}


