using MuOnline.Utilities.Exception;

namespace MuOnline.Utilities.Models
{
    public static class MonsterValidator
    {
        public static void ValidHero(string nameProperty, int value)
        {
            switch (nameProperty)
            {
                case "Strength":
                case "Agility":
                case "Stamina":
                case "Energy":
                    if (value < 0) throw new MonsterValidationException(nameProperty);
                    break;
            }
        }
    }
}
