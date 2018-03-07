using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            double a = 0;
            double c = 0;
            double area = 0;

            if (b == "square")
            {
                double x = double.Parse(Console.ReadLine());
                a = a + x;
                c = c + x;
                area = area + (a * c);
            }
            else if (b == "rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                a = a + x;
                double y = double.Parse(Console.ReadLine());
                c = c + y;
                area = area + (a * c);
            }
            else if (b == "circle")
            {
                double x = double.Parse(Console.ReadLine());
                a = a + x;
                c = c + x;
                area = area + (Math.PI * a * c);
            }
            else if (b == "triangle")
            {
                double x = double.Parse(Console.ReadLine());
                a = a + x;
                double y = double.Parse(Console.ReadLine());
                c = c + y;
                area = area + (a * c/2);
            }
            

            Console.WriteLine($"{area:f3}");

        }
    }
}
