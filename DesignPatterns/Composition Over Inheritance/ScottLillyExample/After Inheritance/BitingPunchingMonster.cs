namespace ScottLillyExample.After_Inheritance
{
    public class BitingPunchingMonster : BitingMonster
    {
        public int PunchDamage { get; set; }

        public BitingPunchingMonster(int hitPoints, int biteDamage, int punchDamage)
            : base(hitPoints, biteDamage)
        {
            PunchDamage = punchDamage;
        }
    }
}
