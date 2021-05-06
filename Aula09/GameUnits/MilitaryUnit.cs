namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; }

        public override int Health => base.Health + XP;

        public override float Value => AttackPower + XP;

        public void Attack(Unit unit)
        {
            // Attack unit...
        }

        public MilitaryUnit(int movement, int health, int attackPower)
            : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public override string ToString()
        {
            return base.ToString() +
                $", AttackPower = {AttackPower}, XP = {XP}";
        }
    }
}