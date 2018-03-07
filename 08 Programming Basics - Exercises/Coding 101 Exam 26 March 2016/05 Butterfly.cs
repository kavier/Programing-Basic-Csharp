using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));

            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
            }
            Console.WriteLine("{0}@", new string (' ',n-1));
            for (int i = 1; i < n / 2; i++)
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
            }

            Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));

        }
    }
}