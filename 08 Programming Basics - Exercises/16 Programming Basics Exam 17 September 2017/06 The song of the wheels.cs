using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            var pass = 0;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (i*j+k*l == n)
                            {
                                if (i < j && k >l)
                                {
                                    count++;
                                    Console.Write($"{i}{j}{k}{l} ");

                                    if (count == 4)
                                    {
                                        pass = int.Parse($"{i}{j}{k}{l}");
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (pass!=0)
            {
                Console.WriteLine($"Password: {pass}");
            }
            else
            {
                Console.WriteLine($"No!");

            }
        }
    }
}
