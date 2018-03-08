using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (2 * n) - 1;
            int hight = (n / 2) + 4;

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));


            for (int i = 1; i < n/2-1; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i), new string(' ', width/2 - 2*i - 2), new string('.', 2*i-1));

            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', n/2-1), new string('.', n-3));

            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n/2), new string('*', (width-1)/2-1-n/2));
            Console.WriteLine("{0}", new string('*', width));
            Console.WriteLine("{0}", new string('*', width));


        }
    }
}
