namespace ScottLillyExample.After_Inheritance
{
    public class BitingKickingMonster : BitingMonster
    {
        public int KickDamage { get; set; }

        public BitingKickingMonster(int hitPoints, int biteDamage, int kickDamage)
            : base(hitPoints, biteDamage)
        {
            KickDamage = kickDamage;
        }
    }
}
