using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha04_chetni_stepeni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= n; i+= 2)
            {

                Console.WriteLine(num);
                num = num * 2 * 2;

            }
        }
    }
}