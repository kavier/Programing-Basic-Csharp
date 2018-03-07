using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double vegieKg = double.Parse(Console.ReadLine());
            double fruitsKg = double.Parse(Console.ReadLine());

            double vegies = n * vegieKg;
            double fruits = m * fruitsKg;

            double  total = (vegies + fruits) / 1.94;

            Console.WriteLine(total);

        }
    }
}