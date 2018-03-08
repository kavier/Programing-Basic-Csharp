using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrizantemi = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double tulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holliday = Console.ReadLine().ToLower();
            double priceHrizantemi = 0.0;
            double priceRoses = 0.0;
            double priceTulips = 0.0;
            double profit = 1.0;
            double seasonDiscount = 1.0;
            double discount = 1.0;

            switch(season)
            {
                case "spring":
                    priceHrizantemi = 2.0;
                    priceRoses = 4.10;
                    priceTulips = 2.50;
                    break;
                case "summer":
                    priceHrizantemi = 2.0;
                    priceRoses = 4.10;
                    priceTulips = 2.50;
                    break;
                case "autumn":
                    priceHrizantemi = 3.75;
                    priceRoses = 4.50;
                    priceTulips = 4.15;
                    break;
                case "winter":
                    priceHrizantemi = 3.75;
                    priceRoses = 4.50;
                    priceTulips = 4.15;
                    break;
            }
            if (holliday=="y")
            {
                profit = 1.15;
            }
            if (season == "spring" && tulips>7)
            {
                seasonDiscount = 0.95;
            }
            else if (season == "winter" && roses >= 10)
            {
                seasonDiscount = 0.9;
            }
            if (hrizantemi+roses+tulips > 20)
            {
                discount = 0.8;
            }

            double answer = ((((hrizantemi * priceHrizantemi + roses * priceRoses + tulips * priceTulips) * profit) * seasonDiscount) * discount) + 2;
            Console.WriteLine($"{answer:f2}");
        }
    }
}
