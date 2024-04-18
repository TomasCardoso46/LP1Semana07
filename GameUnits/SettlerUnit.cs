namespace GameUnits
{
    public class SettlerUnit : Unit // Herança!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public SettlerUnit(int attackPower) : base(movement: 1, health: 3)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public override float Cost // faz override da propriedade Cost
        {
            get { return 5; }
        }
    }
}


