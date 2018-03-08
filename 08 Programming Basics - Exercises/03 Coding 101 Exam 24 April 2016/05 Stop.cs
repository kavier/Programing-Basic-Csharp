using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string ('_', 2*n+1)); // first row

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', (n-i)), new string('_', 2*(n+1)+(2*n+1)-(2*n+4)+2*i)); // middle row

            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (2*(n+1)+(n * 2 + 1) - 9)/2), new string('_', (2 * (n + 1) + (n * 2 + 1) - 9) / 2)); // middle row

            for (int i = n; i >= 1; i--)
            {

                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', (n - i)), new string('_', 2 * (n + 1) + (2 * n + 1) - (2 * n + 4) + 2 * i)); // middle row

            }


        }
    }
}
