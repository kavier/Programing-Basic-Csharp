using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha11
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = 0;
            while (true)
            {
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0) break;


            }

            Console.WriteLine(n);

        }
    }
}