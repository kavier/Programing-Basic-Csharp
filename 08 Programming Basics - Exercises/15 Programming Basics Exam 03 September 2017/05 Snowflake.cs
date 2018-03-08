using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int promenliva = 0;
            int promenliva2 = 0;

            int hight = 2 * n + 1;
            int width = 2 * n + 3;

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', n - i));

                promenliva = i;
                promenliva2 = n - i;
            }

            Console.WriteLine("{0}*****{0}", new string('.', promenliva+1));

            Console.WriteLine("{0}", new string('*', width));

            Console.WriteLine("{0}*****{0}", new string('.', promenliva + 1));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', promenliva-i), new string('.', promenliva2 + i));

            }

        }
    }
}
