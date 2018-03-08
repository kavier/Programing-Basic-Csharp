using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int fights = int.Parse(Console.ReadLine());
            int battles = 0;

            for (int i = 1; i <= player1; i++)
            {
                for (int j = 1; j <= player2; j++)
                {
                    if(battles == fights)
                    {
                        Console.WriteLine();
                        return;
                    }
                    else
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }

                    battles++;

                }
            }
        }
    }
}
