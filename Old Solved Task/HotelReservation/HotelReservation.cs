using System;
using System.Collections.Generic;
using System.Linq;

class HotelReservation
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        double priceOverNight;
        int pricePerOverNight;
        Season typeOfSeason;
        Discount typeOfDiscount;
        PriceCalculator offer;

        if (double.TryParse(splitInput[0], out priceOverNight) &&
            int.TryParse(splitInput[1], out pricePerOverNight) && 
            Enum.TryParse(splitInput[2], out typeOfSeason))
        { 
            if(splitInput.Length > 3)
            {
                Enum.TryParse(splitInput[3], out typeOfDiscount);
                offer =
                   new PriceCalculator(priceOverNight, pricePerOverNight, typeOfSeason, typeOfDiscount);
            }
            else
            {
                offer =
                   new PriceCalculator(priceOverNight, pricePerOverNight, typeOfSeason);
            }

            Console.WriteLine("{0:f2}", offer.MakeOffer()); 
        }

    }
}

