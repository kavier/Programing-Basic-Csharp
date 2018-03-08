using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double akvarium = lenght * width * hight;
            double akvariumLiters = akvarium * 0.001;
            percent = percent * 0.01;

            double result = akvariumLiters * (1 - percent);

            Console.WriteLine($"{result:f3}");

        }
    }
}
