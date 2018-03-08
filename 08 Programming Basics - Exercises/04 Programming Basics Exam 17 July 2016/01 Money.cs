using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double yoans = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double levs = bitcoin * 1168;
            double dollars = yoans * 0.15;
            double levs2 = dollars * 1.76;
            double euro = (levs + levs2) / 1.95;
            double commision = euro * percent / 100;
            double sum = euro - commision;

            Console.WriteLine($"{sum:f2}");

        }
    }
}
