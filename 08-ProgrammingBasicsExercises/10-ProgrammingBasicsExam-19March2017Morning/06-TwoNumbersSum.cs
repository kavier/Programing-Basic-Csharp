using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = a; i >= b; i--)
            {
                for (int j = a; j >= b; j--)
                {
                    sum++;

                    if (i + j == c)
                    {
                        Console.WriteLine($"Combination N:{sum} ({i} + {j} = {c})");
                        return;
                    }

                }
            }

            Console.WriteLine($"{sum} combinations - neither equals {c}");

        }
    }
}
