using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double rows = Math.Floor(w * 100 / 120);
            double colums = Math.Floor(((h * 100) - 100) / 70);

            Console.WriteLine($"{(rows * colums)-3:f0}");
        }
    }
}
