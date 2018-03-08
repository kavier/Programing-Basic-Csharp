using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double secondRoom = smallestRoom * 1.1;
            double thirdRoom = secondRoom * 1.1;
            double bathRoom = smallestRoom * 0.5;
            double allRooms = (smallestRoom + kitchen + thirdRoom + secondRoom + bathRoom)*1.05;
            double appPrice = allRooms * price;

            Console.WriteLine($"{appPrice:f2}");

        }
    }
}
