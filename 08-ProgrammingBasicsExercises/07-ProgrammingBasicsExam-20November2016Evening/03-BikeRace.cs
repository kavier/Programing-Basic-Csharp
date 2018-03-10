using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniorRacers = double.Parse(Console.ReadLine());
            double seniorRacers = double.Parse(Console.ReadLine());
            string race = Console.ReadLine().ToLower();
            double juniors = 0.0;
            double seniors = 0.0;
            double discount = 1.0;


            switch (race)
            {
                case "trail":
                    juniors = 5.50;
                    seniors = 7.00;
                    break;
                case "cross-country":
                    juniors = 8.00;
                    seniors = 9.50;
                    break;
                case "downhill":
                    juniors = 12.25;
                    seniors = 13.75;
                    break;
                case "road":
                    juniors = 20.00;
                    seniors = 21.50;
                    break;
            }
            if (juniorRacers + seniorRacers >= 50 && race == "cross-country")
            {
                discount = 0.75;
            }

            double answer = (((juniorRacers * juniors) + (seniorRacers * seniors)) * discount) * 0.95;

            Console.WriteLine($"{answer:f2}");

        }
    }
}
