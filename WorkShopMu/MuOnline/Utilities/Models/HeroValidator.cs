using MuOnline.Utilities.Exception;

namespace MuOnline.Utilities.Models
{
    public static class HeroValidator 
    {
        public static void ValidHero(string nameProperty, int value)
        {
            
            switch (nameProperty)
            {
                case "Strength":
                case "Agility":
                case "Stamina":
                case "Energy":
                    if (value < 0) throw new HeroValidationException(nameProperty);
                    break;
            }
        }
    }
}
