using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                        
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n), new string('.',n));
            
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', (5 * n) - 2*(n-i) - 2), new string('.', n - i));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('*', 3 * n), new string('*', n));

            for (int i = n; i > 1; i--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i+1), new string('.', (5 * n) - 2 * (n - i) - 4), new string('.', n - i+1));
            }

            for (int i = 0; i < n+1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n + i), new string('.', (5 * n) - 2*(n+i)-2), new string('.', n + i));
            }

            Console.WriteLine("{0}*{1}*{0}", new string('.', 4 * n / 2 + 1), new string('*', n - 4), new string('.', 4 * n / 2 + 1));

        }
    }
}
