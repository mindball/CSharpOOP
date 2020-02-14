﻿
namespace MuOnline.Models.Items.Weapons.Scepter
{
    public class SecretScepter : Item
    {
        private const int strengthPoints = 10;
        private const int agilityPoints = 10;
        private const int staminaPoints = 20;
        private const int energyPoints = 50;

        public SecretScepter() 
            : base(strengthPoints, agilityPoints, staminaPoints, energyPoints)
        {
        }
    }
}
