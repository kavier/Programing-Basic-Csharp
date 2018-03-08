using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double percent = 1;
            string place = "shit2";
            string location = "shit";

            if (budget <= 1000)
            {
                place = "Camp";

                switch (season)
                {
                    case "summer":
                        percent = 0.65;
                        location = "Alaska";
                        break;
                    case "winter":
                        percent = 0.45;
                        location = "Morocco";
                        break;
                }
            }
            else if (budget <= 3000)
            {
                place = "Hut";

                switch (season)
                {
                    case "summer":
                        location = "Alaska";
                        percent = 0.8;
                        break;
                    case "winter":
                        percent = 0.60;
                        location = "Morocco";

                        break;
                }
            }
            else if (budget>3000)
            {
                place = "Hotel";

                switch (season)
                {
                    case "summer":
                        percent = 0.9;
                        location = "Alaska";

                        break;
                    case "winter":
                        percent = 0.9;
                        location = "Morocco";

                        break;
                }
            }

            Console.WriteLine($"{location} - {place} - {budget * percent:f2}");
        }
    }
}
