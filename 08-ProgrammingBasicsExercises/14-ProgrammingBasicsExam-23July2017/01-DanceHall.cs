using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double hall = (l * 100) * (w * 100);
            double garderob = (a * 100) * (a * 100);
            double peika = hall / 10;
            double freeSpace = hall - garderob - peika;

            double dancers = freeSpace / (40 + 7000);

            dancers = Math.Floor(dancers);

            Console.WriteLine($"{dancers}");

        }
    }
}
