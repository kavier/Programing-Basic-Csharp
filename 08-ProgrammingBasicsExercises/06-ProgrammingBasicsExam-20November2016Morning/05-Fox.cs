using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int constanta = n;
            int stars = 1;
            int middle = (n * 2) - 1;

            int rows = (2 * n + n / 3); 
            int colums = 2 * n + 3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i + 1), new string('-', colums - 2 * (i + 1) - 2));
                stars++;
                middle -= 2;

            }

            for (int i = 0; i < rows - 2*n; i++)
            {
                Console.WriteLine("|{0}\\{1}*{1}/{0}|", new string('*', n/2+i), new string('*', n / 2 - i));
                stars++;
                middle -= 2;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i + 1), new string('*', colums - 2 * (i + 1) - 2));
            }
        }
    }
}
