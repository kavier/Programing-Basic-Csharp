using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double floor = n * n;
            double bench = m * o;
            double work = floor - bench;
            double tiles = w * l;
            double neededTiles = work / tiles;
            double timeNeeded = neededTiles * 0.2;

            Console.WriteLine($"{neededTiles:f2}");
            Console.WriteLine($"{timeNeeded:f2}");

        }
    }
}
