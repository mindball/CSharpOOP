﻿namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
    public class BuffGloves : Item
    {
        private const int strengthPoints = 13;
        private const int agilityPoints = 15;
        private const int staminaPoints = 0;
        private const int energyPoints = 10;

        public BuffGloves()
            : base(strengthPoints, agilityPoints, staminaPoints, energyPoints)
        {
        }
    }
}
