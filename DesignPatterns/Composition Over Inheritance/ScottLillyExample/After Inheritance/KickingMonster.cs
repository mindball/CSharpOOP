namespace ScottLillyExample.After_Inheritance
{
    public class KickingMonster : Monster
    {
        public int KickDamage { get; set; }

        public KickingMonster(int hitPoints, int kickDamage)
            : base(hitPoints)
        {
            KickDamage = kickDamage;
        }
    }
}
