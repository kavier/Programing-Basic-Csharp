using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha9
{
    class Program
    {
        static void Main(string[] args)
        {
            var tc = double.Parse(Console.ReadLine());

            double tf = (tc * 1.8) + 32;
            Console.WriteLine(Math.Round(tf, 2));
        }
    }
}
