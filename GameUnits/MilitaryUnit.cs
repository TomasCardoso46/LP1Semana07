namespace GameUnits
{
    public class MilitaryUnit : Unit // Herança!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health //  faz override da propriedade Health
        {
            get { return base.Health + XP; }
            set { base.Health = value; }
        }

        public override float Cost // faz override da propriedade Cost
        {
            get { return AttackPower + XP; }
        }

        public void Attack(Unit u) // metodo Attack
        {
            XP++; // vai aumentadndo XP da própria unidade
            u.Health -= AttackPower;
        }
    }
}

