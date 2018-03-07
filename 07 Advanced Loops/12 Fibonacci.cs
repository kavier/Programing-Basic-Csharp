using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var f1 = 1;
            var f2 = 1;

            for (int i = 0; i < n-1; i++)
            {
                var currentFibonacci = f1 + f2;
                f1 = f2;
                f2 = currentFibonacci;
            }

            Console.WriteLine(f2);
        }
    }
}
