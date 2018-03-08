using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWalls = 2 * (x * y) - 2 * 2.25;
            double frontAndBackWalls = 2 * (x * x) - 2.4;
            double houseSize = sideWalls + frontAndBackWalls;
            double greenPaint = houseSize / 3.4;

            double sideRoof = 2 * (x * y);
            double frondAndBackRoof = 2 * (x * h / 2);
            double roofSize = sideRoof + frondAndBackRoof;
            double redPaint = roofSize / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}