using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n>100 || n<1)
            {

                
                n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(n);

        }
    }
}