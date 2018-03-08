using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double twoSides = a * (a / 2) * 2;
            double backSide = ((a / 2) * (a / 2)) + ((a / 2 * (b - a / 2)) / 2);
            double entrance = (a / 5) * (a / 5);
            double frontSide = backSide - entrance;

            double walls = twoSides + backSide + frontSide;
            double greenPaint = walls / 3;
            double roof = a * (a / 2) * 2;

            double redPaint = roof / 5;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
