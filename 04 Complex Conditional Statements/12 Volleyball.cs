using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha12
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double Sofia = (48 - h);
            double satSofia = Sofia * 3.0 / 4;
            double praSofia = p * 2.0 / 3;
            double x = 0.00;
            
            if (year == "leap")
            {
                x = 1.15;
                double games = (satSofia + h + praSofia) * x;
                Console.WriteLine(Math.Truncate(games));
            }
            else if (year == "normal")
            {
                double games = (satSofia + h + praSofia);
                Console.WriteLine(Math.Truncate(games));
            }
        }
    }
}
