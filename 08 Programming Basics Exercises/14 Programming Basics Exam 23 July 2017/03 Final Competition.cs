using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            double dancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();
            double bonus = 1.0;
            double expences = 0.0;

            if (place == "bulgaria")
            {
                switch(season)
                {
                    case "summer":
                        expences = 0.95;
                        break;
                    case "winter":
                        expences = 0.92;
                        break;
                }
            }
            else if (place == "abroad")
            {
                bonus = 1.5;
                switch (season)
                {
                    case "summer":
                        expences = 0.90;
                        break;
                    case "winter":
                        expences = 0.85;
                        break;
                }
            }

            double profit = ((points * dancers) * bonus) * expences;
            double charity = profit * 0.75;
            double moneyPerDancer = (profit - charity) / dancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");

        }
    }
}
