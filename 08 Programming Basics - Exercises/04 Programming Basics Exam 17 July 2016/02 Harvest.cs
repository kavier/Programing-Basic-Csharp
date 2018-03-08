using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double grapeArea = double.Parse(Console.ReadLine());
            double literPerSqMetters = double.Parse(Console.ReadLine());
            double neededLiters = double.Parse(Console.ReadLine());
            double employees = double.Parse(Console.ReadLine());

            double totalGrapes = grapeArea * literPerSqMetters;
            double wine = totalGrapes * 0.4 / 2.5;

            if (wine >= neededLiters)
            {
                double diff = wine - neededLiters;
                double fuck = diff / employees;

                fuck = Math.Ceiling(fuck);
                wine = Math.Floor(wine);

                Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.");
                Console.WriteLine($"{diff:f0} liters left -> {fuck} liters per person.");

            }
            else
            {
                double diff = neededLiters - wine;
                diff = Math.Floor(diff);

                Console.WriteLine($"It will be a tough winter! More {diff} liters wine needed.");
            }

        }
    }
}
