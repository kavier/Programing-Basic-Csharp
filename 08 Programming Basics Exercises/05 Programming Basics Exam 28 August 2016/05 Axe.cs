using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.bradva_avtorsko_reshenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int width = 5 * n;
            int first = 3*n;
            int second = 0;
            int third = width-first-second-2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', first), new string('-', second), new string('-', third));
                second++;
                third--;
            }

            second--;
            third++;

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', first), new string('-',second), new string('-', third));

            }

            for (int i = 0; i < n / 2-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', first), new string('-', second), new string('-', third));
                first--;
                second+=2;
                third--;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', first), new string('*', second), new string('-', third));

        }
    }
}
