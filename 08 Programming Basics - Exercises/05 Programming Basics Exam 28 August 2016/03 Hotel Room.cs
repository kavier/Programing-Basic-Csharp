using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double priceAp = 0.0;
            double priceStudio = 0.0;
            double discountStudio = 1.0;
            double discountAp = 1.0;

            if (month == "May" || month == "October")
            {
                priceAp = 65;
                priceStudio = 50;

                if (nights > 14)
                {
                    discountStudio = 0.7;
                    discountAp = 0.9;
                }
                else if (nights > 7)
                {
                    discountStudio = 0.95;

                }
            }
            else if (month == "June" || month == "September")
            {
                priceAp = 68.70;
                priceStudio = 75.20;

                if (nights > 14)
                {
                    discountStudio = 0.8;
                    discountAp = 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceAp = 77;
                priceStudio = 76;

                if (nights > 14)
                {
                    discountAp = 0.9;
                }
            }

            Console.WriteLine($"Apartment: {nights * priceAp * discountAp:f2} lv.");
            Console.WriteLine($"Studio: {nights * priceStudio * discountStudio:f2} lv.");


        }
    }
}
