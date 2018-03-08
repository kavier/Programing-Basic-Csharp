using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnolii = double.Parse(Console.ReadLine());
            double zyumbiul = double.Parse(Console.ReadLine());
            double rose = double.Parse(Console.ReadLine());
            double cactus = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double priceMagnolii = 3.25;
            double priceZyumbiul = 4.00;
            double priceRose = 3.50;
            double priceCactus = 8.00;

            double order = magnolii * priceMagnolii + zyumbiul * priceZyumbiul + rose * priceRose + cactus * priceCactus;
            double taxes = order*0.05;

            double answer = order - taxes;

            if (answer >= giftPrice)
            {
                double sum = answer - giftPrice;
                sum = Math.Floor(sum);
                Console.WriteLine($"She is left with {sum} leva.");
            }
            else
            {
                double sum = giftPrice - answer;
                sum = Math.Ceiling(sum);
                Console.WriteLine($"She will have to borrow {sum} leva.");
            }

        }
    }
}
