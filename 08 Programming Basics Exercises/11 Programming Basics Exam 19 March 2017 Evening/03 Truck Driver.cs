using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double milePerMonth = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (milePerMonth <= 5000)
            {
                switch (season)
                {
                    case "summer":
                        price = 0.9;
                        break;
                    case "spring":
                        price = 0.75;
                        break;
                    case "autumn":
                        price = 0.75;
                        break;
                    case "winter":
                        price = 1.05;
                        break;
                }
            }
            else if (milePerMonth < 10000)
            {
                switch (season)
                {
                    case "summer":
                        price = 1.1;
                    break;
                    case "spring":
                        price = 0.95;
                    break;
                    case "autumn":
                        price = 0.95;
                    break;
                    case "winter":
                        price = 1.25;
                    break;
                }
            }
            else if (milePerMonth<=20000)
            {
                price = 1.45;
            }

            double salary = 4 * (milePerMonth * price) * 0.9;

            Console.WriteLine($"{salary:f2}");
        }
    }
}
