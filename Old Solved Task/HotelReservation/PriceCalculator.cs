using System;
using System.Collections.Generic;
using System.Linq;

class PriceCalculator
{
    public PriceCalculator(double pricePerDay, int numberOfOverNight, Season season, Discount discount = 0)
    {
        this.PricePerDay = pricePerDay;
        this.NumberOfOverNight = numberOfOverNight;
        this.TypeOfSeason = season;
        this.TypeOfDiscount = discount;
    }

    public double PricePerDay { get; set; }
    public int NumberOfOverNight { get; set; }
    public Season TypeOfSeason { get; set; }
    public Discount TypeOfDiscount { get; set; }

    public double MakeOffer()
    {
        double totalPrice = 0.0;
        double discount = 0;
        switch(this.TypeOfSeason)
        {
            case Season.Autumn:
                this.PricePerDay *= (int)Season.Autumn;
            break;
            case Season.Spring:
                this.PricePerDay *= (int)Season.Spring;
                break;
            case Season.Winter:
                this.PricePerDay *= (int)Season.Winter;
                break;
            case Season.Summer:
                this.PricePerDay *= (int)Season.Summer;
                break;
        }

        switch(this.TypeOfDiscount)
        {
            case Discount.None:
                discount = (double)this.TypeOfDiscount / 100;
                break;
            case Discount.SecondVisit:
                discount = (double)this.TypeOfDiscount / 100;
                break;
            case Discount.VIP:
                discount = (double)this.TypeOfDiscount / 100;
                break;
        }

        totalPrice = (this.NumberOfOverNight * this.PricePerDay) - ((this.NumberOfOverNight * this.PricePerDay) * discount);  
        return totalPrice;
    }


}

