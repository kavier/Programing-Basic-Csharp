using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (4 * n) + 1;
                int hight = (2 * n) + 1;
            int promenliva = 0;
            int promenliva2 = 0;

            Console.WriteLine("{0}", new string('#', width));
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(".{0}{1}{2} {2}{1}{0}.", new string('.', i), new string('#', 2*n-1-2*i), new string(' ', i));
                promenliva = 2 * n - 1 - 2 * i;
                promenliva2 = i;
            }

            Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', n/2+1), new string('#', promenliva-2), new string(' ', n/2-1));

            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.WriteLine("{0}{1}{2} {2}{1}{0}", new string('.', n / 2 + 2 + i), new string('#', promenliva - 4 - 2*i), new string(' ', n / 2 +1+i));

            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}#{1}{0}", new string('.', n + i), new string('#', n-i));

            }
        }
    }
}
