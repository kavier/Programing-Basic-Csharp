using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha03_0t1do2naN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
                
            BigInteger num = 1;

            for (int i = 0; i <= n; i++)
            {

                Console.WriteLine(num);

                num = num * 2;
                
            }
        }
    }
}