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

        public override int Health // Override da propriedade Health
        {
            get { return base.Health + XP; }
            set { base.Health = value; }
        }

        public override float Cost // Override da propriedade Cost
        {
            get { return AttackPower + XP; }
        }

        public void Attack(Unit u) // Método Attack
        {
            XP++; // Incrementa XP da própria unidade

            // Aplica dano igual a AttackPower na Health da unidade atacada
            u.Health -= AttackPower;
        }
    }
}

