namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
    class BuffPants : Item
    {
        private const int strengthPoints = 13;
        private const int agilityPoints = 15;
        private const int staminaPoints = 0;
        private const int energyPoints = 20;

        public BuffPants()
            : base(strengthPoints, agilityPoints, staminaPoints, energyPoints)
        {
        }
    }
}
