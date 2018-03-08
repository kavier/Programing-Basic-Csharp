using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string groupType = Console.ReadLine().ToLower();
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            double price = 0.0;
            double discount = 1.0;
            string sport = " ";

            if (season == "winter")
            {
                switch (groupType)
                {
                    case "boys":
                        price = 9.60;
                        sport = "Judo";
                        break;
                    case "girls":
                        sport = "Gymnastics";
                        price = 9.60;
                        break;
                    case "mixed":
                        price = 10.00;
                        sport = "Ski";
                        break;
                }
            }
            else if (season == "spring")
            {
                switch (groupType)
                {
                    case "boys":
                        price = 7.20;
                        sport = "Tennis";
                        break;
                    case "girls":
                        price = 7.20;
                        sport = "Athletics";
                        break;
                    case "mixed":
                        price = 9.50;
                        sport = "Cycling";
                        break;
                }
            }
            else if (season == "summer")
            {
                switch (groupType)
                {
                    case "boys":
                        price = 15.00;
                        sport = "Football";
                        break;
                    case "girls":
                        price = 15.00;
                        sport = "Volleyball";
                        break;
                    case "mixed":
                        price = 20.00;
                        sport = "Swimming";
                        break;
                }
            }
            if (students>=50)
            {
                discount = 0.5;
            }
            else if (students>=20)
            {
                discount = 0.85;
            }
            else if (students>=10)
            {
                discount = 0.95;
            }

            Console.WriteLine($"{sport} {students * price * discount * nights:f2} lv.");
        }
    }
}
