using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string clas;
            string tip = "general";
            double percent = 0.0;


            if (budget > 500)
            {
                clas = "Luxury class";
                tip = "Jeep";
                percent = 0.9;
            }
            else if (budget > 100)
            {
                clas = "Compact class";

                switch (season)
                {
                    case "winter":
                        tip = "Jeep";
                        percent = 0.8;
                        break;
                    case "summer":
                        tip = "Cabrio";
                        percent = 0.45;
                        break;
                }

            }
            else
            {
                clas = "Economy class";

                switch (season)
                {
                    case "winter":
                        tip = "Jeep";
                        percent = 0.65;
                        break;
                    case "summer":
                        tip = "Cabrio";
                        percent = 0.35;
                        break;
                }
            }

            Console.WriteLine($"{clas}");
            Console.WriteLine($"{tip} - {budget*percent:f2}");

        }
    }
}
