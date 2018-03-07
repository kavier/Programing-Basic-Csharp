using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha11
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());
            double price = 0;


            if (type == "premiere")
            {
                    price = 12.00;
                    double x = rows * columns * price;
                    Console.WriteLine("{0:f2}", x);
            }
            else if (type == "normal")
            {
                price = 7.50;
                double x = rows * columns * price;
                Console.WriteLine("{0:f2}", x);
            }
            else if (type == "discount")
            {
                price = 5.00;
                double x = rows * columns * price;
                Console.WriteLine("{0:f2}", x);
            }
            else
            {
                Console.WriteLine("error");
           }

        }
    }
}
