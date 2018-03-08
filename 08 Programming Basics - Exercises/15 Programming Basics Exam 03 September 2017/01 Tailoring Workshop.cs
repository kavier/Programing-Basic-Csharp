using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfTables = double.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double sizePokrivki = numberOfTables * (tableLenght+2*0.3) * (tableWidth+2 * 0.3);
            double kare = numberOfTables * (tableLenght / 2) * (tableLenght / 2);

            double priceDollars = sizePokrivki * 7 + kare * 9;
            double priceLevs = priceDollars * 1.85;

            Console.WriteLine($"{priceDollars:f2} USD");
            Console.WriteLine($"{priceLevs:f2} BGN");

        }
    }
}
