using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n + 6;
            int hight = 3 * n + 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', n));
            }

            Console.WriteLine("{0}", new string('=', width-1));

            for (int i = 0; i < n - 2; i++)
            {

                if (i == (n - 2) / 2)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));

                }
                else
                {
                    Console.WriteLine("|{0}~~~~{0}|{1}|", new string('~', n), new string(' ', n - 1));
                }
            }
            Console.WriteLine("{0}", new string('=', width - 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}@@@@@@{1}/", new string(' ', i), new string('@', n - 1-i));

            }
            Console.WriteLine("{0}", new string('=', 2*n+6));

        }
    }
}
