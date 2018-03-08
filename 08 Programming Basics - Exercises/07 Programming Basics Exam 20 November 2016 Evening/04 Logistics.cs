using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFfreights = int.Parse(Console.ReadLine());
            double freightOver12tons = 0;
            double freightOver4tons = 0;
            double freightUpTo3tons = 0;
            double totalFreight = 0;

            for (int i = 0; i < numberOFfreights; i++)
            {
                double freightWeight = double.Parse(Console.ReadLine());

                if (freightWeight >= 12)
                {
                    freightOver12tons += freightWeight;
                }
                else if (freightWeight >= 4)
                {
                    freightOver4tons += freightWeight;
                }
                else
                {
                    freightUpTo3tons += freightWeight;
                }
                totalFreight += freightWeight;
            }

            double price = ((freightUpTo3tons * 200) + (freightOver4tons * 175) + (freightOver12tons * 120)) / totalFreight;
            double bus = freightUpTo3tons / totalFreight * 100;
            double truck = freightOver4tons / totalFreight * 100;
            double train = freightOver12tons / totalFreight * 100;

            Console.WriteLine($"{price:f2}");
            Console.WriteLine($"{bus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");

        }
    }
}
