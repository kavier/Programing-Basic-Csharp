using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var a = double.Parse(Console.ReadLine());
            var cm = a * 2.54;
            Console.Write("centimeters = ");
            Console.WriteLine(cm);
        }
    }
}
