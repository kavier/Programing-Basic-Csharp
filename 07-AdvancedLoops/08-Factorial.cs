using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum = sum * i;
            }

            Console.WriteLine(sum);
        }
    }
}
