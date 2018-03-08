using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int combination = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    int comb = i + j;

                    combination++;

                    if  (comb == c)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {c})");
                        return;
                    }
                    
                }
            }
            
                Console.WriteLine($"{combination} combinations - neither equals {c}");
            
            
        }
    }
}
