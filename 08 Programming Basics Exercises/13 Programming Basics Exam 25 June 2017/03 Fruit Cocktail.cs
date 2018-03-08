using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string coctailSize = Console.ReadLine().ToLower();
            double numberOfDrinks = double.Parse(Console.ReadLine());
            double price = 0.0;
            double volume = 0.0;
            double discount = 1.0;

            if (fruit == "watermelon")
            {
                switch (coctailSize)
                {
                    case "small":
                        volume = 2.0;
                        price = 56.00;
                        break;
                    case "big":
                        volume = 5.0;
                        price = 28.70;
                        break;
                }

            }
            else if (fruit == "mango")
            {
                switch (coctailSize)
                {
                    case "small":
                        volume = 2.0;
                        price = 36.66;
                        break;
                    case "big":
                        volume = 5.0;
                        price = 19.60;
                        break;
                }
            }
            else if (fruit == "pineapple")
            {
                switch (coctailSize)
                {
                    case "small":
                        volume = 2.0;
                        price = 42.10;
                        break;
                    case "big":
                        volume = 5.0;
                        price = 24.80;
                        break;
                }
            }
            else if (fruit == "raspberry")
            {
                switch (coctailSize)
                {
                    case "small":
                        volume = 2.0;
                        price = 20.00;
                        break;
                    case "big":
                        volume = 5.0;
                        price = 15.20;
                        break;
                }
            }

            double sum = volume * price * numberOfDrinks;

            if (sum > 1000)
            {
                discount = 0.5;
            }
            else if (sum >= 400)
            {
                discount = 0.85;
            }

            double result = sum * discount;

            Console.WriteLine($"{result:f2} lv.");


        }
    }
}
