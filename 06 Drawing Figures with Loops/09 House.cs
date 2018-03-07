using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 0;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            var padding = (n - stars) / 2;
            Console.Write(new string('-', padding));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', padding));
            for (int i = 1; i < (n + 1) / 2; i++)
            {
                stars = stars + 2;
                padding = padding - 1;
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', padding));
            }
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");

                Console.WriteLine();

            }
        }
    }
}

