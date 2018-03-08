using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            double liters = 0.0;

            for (int i = 0; i < n; i++)
            {
                var quantity = double.Parse(Console.ReadLine());
                var degrees = double.Parse(Console.ReadLine());
                double days = quantity * degrees;
                sum += days;
                liters += quantity;
            }
            double answer = sum / liters;
            Console.WriteLine($"Liter: {liters:f2}");
            Console.WriteLine($"Degrees: {answer:f2}");

            if (answer < 38)
            {
                Console.WriteLine($"Not good, you should baking!");

            }
            else if (answer < 42)
            {
                Console.WriteLine($"Super!");

            }
            else
            {
                Console.WriteLine($"Dilution with distilled water!");

            }
        }
    }
}
