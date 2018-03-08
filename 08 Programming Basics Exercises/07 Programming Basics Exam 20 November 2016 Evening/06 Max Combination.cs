using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int fights = 0;


            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    if (fights == c)
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.Write($"<{i}-{j}>");
                     
                    }

                    fights++;
                }
            }

        }
    }
}
