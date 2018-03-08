using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dogDaily = double.Parse(Console.ReadLine());
            double catDaily = double.Parse(Console.ReadLine());
            double turtleDaily = double.Parse(Console.ReadLine());

            double dog = days * dogDaily;
            double cat = days * catDaily;
            double turtle = days * (turtleDaily * 0.001);

            double result = dog + cat + turtle;

            double answer = 0.0;

            if (result <= food)
            {
                answer = food - result;
                answer = Math.Floor(answer);

            Console.WriteLine($"{answer} kilos of food left.");

            }
            else
            {
                answer = result - food;
                answer = Math.Ceiling(answer);

                Console.WriteLine($"{answer} more kilos of food are needed.");
            }
        }
    }
}
