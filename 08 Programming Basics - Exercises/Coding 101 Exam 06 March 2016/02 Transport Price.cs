using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string when = Console.ReadLine();
            var price = 0.0;

            if (n>=100)
            {
                price = n * 0.06;
            }
            else if (n<20)
            {
                if (when == "day")
                {
                    price = 0.7 + (n * 0.79);
                }
                else
                {
                    price = 0.7 + (n * 0.90);
                }
            }
            else
            {
                price = n * 0.09;
            }

            Console.WriteLine($"{price}");
        }
    }
}