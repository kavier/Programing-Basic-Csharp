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
            double a = double.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            double rate1 = 0;
            double rate2 = 0;

            if (b == "m")
            {
                rate1 = 1;
            }
            else if (b == "mm")
            {
                rate1 = 1000;
            }
            else if (b == "cm")
            {
                rate1 = 100;
            }
            else if (b == "mi")
            {
                rate1 = 0.000621371192;
            }
            else if (b == "in")
            {
                rate1 = 39.3700787;
            }
            else if (b == "km")
            {
                rate1 = 0.001;
            }
            else if (b == "ft")
            {
                rate1 = 3.2808399;
            }
            else if (b == "yd")
            {
                rate1 = 1.0936133;
            }
            if (c == "m")
            {
                rate2 = 1;
            }
            else if (c == "mm")
            {
                rate2 = 1000;
            }
            else if (c == "cm")
            {
                rate2 = 100;
            }
            else if (c == "mi")
            {
                rate2 = 0.000621371192;
            }
            else if (c == "in")
            {
                rate2 = 39.3700787;
            }
            else if (c == "km")
            {
                rate2 = 0.001;
            }
            else if (c == "ft")
            {
                rate2 = 3.2808399;
            }
            else if (c == "yd")
            {
                rate2 = 1.0936133;
            }
            double result = (a / rate1) * rate2;

            Console.WriteLine(Math.Round(result, 8));
        }
    }
}
