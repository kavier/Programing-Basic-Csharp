using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            var percent = 1.0;
            string place = "";
            string a = "";

            if (budget <= 100)
            {
                place = "Bulgaria";

                switch (season)
                {
                    case "summer":
                        percent = 0.30;
                        a = "Camp";
                        break;
                    case "winter":
                        percent = 0.70;
                        a = "Hotel";
                        break;
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";
                percent = 0.90;
                a = "Hotel";
            }
            else
            {

                place = "Balkans";

                switch (season)
                {
                    case "summer":
                        percent = 0.40;
                        a = "Camp";
                        break;
                    case "winter":
                        percent = 0.80;
                        a = "Hotel";
                        break;
                }
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{a} - {budget*percent:f2}");

        }
    }
}