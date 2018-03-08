using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int high = 4 * n - 2;
            int width = 12 * n - 5;

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', width/2 - 3 * i), new string('#', 1 + 6 * i));
            }

            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("|{0}{1}{0}.", new string('.', 3 * i - 1), new string('#', width - 6*i));
            }

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("|{0}{1}{0}.", new string('.', 3 * n - 4), new string('#', 6 * n +1));

            }

            Console.WriteLine("@{0}{1}{0}.", new string('.', (width- 6 * n + 1)/2 - 2), new string('#', 6 * n+1));

        }
    }
}
