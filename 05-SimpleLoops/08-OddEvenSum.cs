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

            int odd = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0) odd += num;
                else even += num;
                                
            }
            if (odd == even)
            {
                Console.WriteLine("yes sum " + odd);
            }
            else
            {
                Console.WriteLine("no diff " + Math.Abs(odd - even));
            }
        }
    }
}
