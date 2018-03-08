using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string zone = Console.ReadLine();
            double people = double.Parse(Console.ReadLine());
            double price = 0.0;
            double percent = 0;

            switch (zone)
            {
                case "VIP":
                price = 499.99;
                    break;
                case "Normal":
                price = 249.99;
                    break;
            }

            if (people >= 50)
            {
                percent = 0.25;
            }
            else if (people >= 25 && people < 50)
            {
                percent = 0.40;
            }
            else if (people >= 10 && people < 25)
            {
                percent = 0.50;
            }
            else if (people >= 5 && people < 10)
            {
                percent = 0.60;
            }
            else if (people > 0 && people < 5)
            {
                percent = 0.75;
            }

            var transport = budget * percent;
            var pay = budget - transport;
            var cost = price*people;

            if (pay > cost)
            {
                Console.WriteLine($"Yes! You have {pay - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {cost-pay:f2} leva.");
            }
        }
    }
}
