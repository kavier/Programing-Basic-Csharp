using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseSize = double.Parse(Console.ReadLine());
            double numberOfWindows = double.Parse(Console.ReadLine());
            double styrofoamInPack = double.Parse(Console.ReadLine());
            double styrofoamPackPrice = double.Parse(Console.ReadLine());

            double styrofoamArea = (houseSize - numberOfWindows * 2.4) * 1.1;
            double neededPacks = Math.Ceiling(styrofoamArea / styrofoamInPack);
            double neededMoney = neededPacks * styrofoamPackPrice;

            if (neededMoney>budget)
            {
                Console.WriteLine($"Need more: {neededMoney - budget:f2}");
            }
            else
            {
                Console.WriteLine($"Spent: {neededMoney:f2}");
                Console.WriteLine($"Left: {budget- neededMoney:f2}");


            }

        }
    }
}
