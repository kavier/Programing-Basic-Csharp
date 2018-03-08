using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int moves = 0;
            int scores = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    moves++;

                    int promenliva = i * 2 + j * 3;

                    scores += promenliva;

                    if (scores >= controlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {scores} >= {controlNumber}");
                        return;
                    }

                }
            }
                Console.WriteLine($"{moves} moves");
            }
        }
    }

