using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;
            int hight = 2 * n + 8;

            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 1) / 2 - 1));
            Console.WriteLine("{0}x|x{0}", new string('.', (width - 1) / 2 - 1));
            int promenliva1 = 0;
            int promenliva2 = 0;

            for (int i = 0; i <= n/2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', (width - 1) / 2 - n-i), new string('x', n+i));
                promenliva1 = (width - 1) / 2 - n - i;
                promenliva2 = n + i;
            }
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', promenliva1+i), new string('x', promenliva2-i));

            }

            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 1) / 2 - 1));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 1) / 2 - 1));

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', (width - 1) / 2 - n - i), new string('x', n + i));
                promenliva1 = (width - 1) / 2 - n - i;
                promenliva2 = n + i;
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', promenliva1 + i), new string('x', promenliva2 - i));

            }
            Console.WriteLine("{0}x|x{0}", new string('.', (width - 1) / 2 - 1));

            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 1) / 2 - 1));
            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));

        }
    }
}
