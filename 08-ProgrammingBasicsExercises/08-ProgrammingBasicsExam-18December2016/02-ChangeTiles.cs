using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double collectedMoney = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double masterPay = double.Parse(Console.ReadLine());

            double floor = width * lenght;
            double tileSize = triangleHight * triangleSide / 2;
            double neededTiles = floor / tileSize + 5;
            neededTiles = Math.Ceiling(neededTiles);
            double sum = neededTiles * tilePrice + masterPay;

            if (sum > collectedMoney)
            {
                double answer = sum - collectedMoney;
                Console.WriteLine($"You'll need {answer:f2} lv more.");
            }
            else
            {
                double answer = collectedMoney - sum;
                Console.WriteLine($"{answer:f2} lv left.");
            }
        }
    }
}
