using MuOnline.Utilities.Exception;

namespace MuOnline.Utilities.Models
{
    public static class ItemValidator
    {

        public static void ValidItem(string nameProperty, int value)
        {             
            switch (nameProperty)
            {
                case "Strength":
                case "Agility":
                case "Stamina":
                case "Energy":
                    if (value < 0) throw new ItemValidationException(nameProperty);
                    break;               
            }
        }
    }
}
