using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;

            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());

                var two = number % 2;
                var three = number % 3;
                var four = number % 4;

                
                if (two == 0)
                    p1 += 1;

                if (three == 0)
                    p2 += 1;

                if (four == 0)
                    p3 += 1;
            }

            var numTwo = p1 / n * 100;
            var numThree = p2 / n * 100;
            var numFour = p3 / n * 100;

            Console.WriteLine($"{numTwo:f2}%");
            Console.WriteLine($"{numThree:f2}%");
            Console.WriteLine($"{numFour:f2}%");

        }
    }
}
