using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            double placeLenght = double.Parse(Console.ReadLine());
            double placeWidth = double.Parse(Console.ReadLine());
            double netHight = double.Parse(Console.ReadLine());
            double netPrice = double.Parse(Console.ReadLine());
            double netWeight = double.Parse(Console.ReadLine());

            double netLenght = 2 * placeLenght + 2 * placeWidth;
            double wireNetPrice = netLenght * netPrice;
            double netArea = netLenght * netHight;
            double wireNetWeight = netArea * netWeight;

            Console.WriteLine($"{netLenght:f0}");
            Console.WriteLine($"{wireNetPrice:f2}");
            Console.WriteLine($"{wireNetWeight:f3}");

        }
    }
}
