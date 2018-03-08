using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());
            double result = 0.0;

            double cleaningTime = (1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother)) * 1.15;

            double a = cleaningTime;


            if (cleaningTime < father)
            {
                result = father - cleaningTime;
                result = Math.Floor(result);
                Console.WriteLine($"Cleaning time: {a:f2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {result} hours.");

            }
            else
            {
                result = cleaningTime - father;
                result = Math.Ceiling(result);

                Console.WriteLine($"Cleaning time: {a:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {result} hours.");

            }

            result = Math.Floor(result);
        }
    }
}
