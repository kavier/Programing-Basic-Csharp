using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractTerm = Console.ReadLine().ToLower();
            string contractType = Console.ReadLine().ToLower();
            string inet = Console.ReadLine().ToLower();
            double months = double.Parse(Console.ReadLine());
            double price = 0.0;
            double inetPrice = 0.0;
            double discount = 1.0;

            if (contractTerm == "one")
            {
                switch (contractType)
                {
                    case "small":
                        price = 9.98;
                        break;
                    case "middle":
                        price = 18.99;
                        break;
                    case "large":
                        price = 25.98;
                        break;
                    case "extralarge":
                        price = 35.99;
                        break;
                }
            }
            else if (contractTerm == "two")
            {
                discount = 0.9625;

                switch (contractType)
                {
                    case "small":
                        price = 8.58;
                        break;
                    case "middle":
                        price = 17.09;
                        break;
                    case "large":
                        price = 23.59;
                        break;
                    case "extralarge":
                        price = 31.79;
                        break;
                }

            }

            if (inet == "yes")
            {
                switch (contractType)
                {
                    case "small":
                        inetPrice = 5.5;
                        break;
                    case "middle":
                        inetPrice = 4.35;
                        break;
                    case "large":
                        inetPrice = 4.35;
                        break;
                    case "extralarge":
                        inetPrice = 3.85;
                        break;
                }
            }

            double sum1 = (price + inetPrice);
            double sum2  = sum1 * discount;
            double sum = sum2 * months;

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
