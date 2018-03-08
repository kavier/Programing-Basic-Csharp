using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 4 * n + 1;
            int hight = 2 * n + 5;

            Console.WriteLine("{0}/|\\{0}", new string('.', (width - 1) / 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', (width - 1) / 2 - 1));

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', (width - 1) / 2 - 1 - i), new string ('-', i));
            }

            Console.WriteLine("{0}", new string('*', width));

            for (int i = 0; i < 2*n; i++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.WriteLine("*");

            Console.WriteLine("{0}", new string('*', width));



        }
    }
}
