namespace ScottLillyExample.Before_Inheritance
{
    public class Monster
    {
        public Monster(int hitPoints, int attackDamage)
        {
            HitPoints = hitPoints;
            AttackDamage = attackDamage;
        }
        public int HitPoints { get; set; }
        public int AttackDamage { get; set; }

    }
}
