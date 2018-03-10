using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha07
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            if (day == "monday"|| day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (product == "banana")
                    Console.WriteLine(2.50 * quantity);
                else if (product == "apple")
                    Console.WriteLine(1.20 * quantity);
                else if (product == "orange")
                    Console.WriteLine(0.85 * quantity);
                else if (product == "grapefruit")
                    Console.WriteLine(1.45 * quantity);
                else if (product == "kiwi")
                    Console.WriteLine(2.70 * quantity);
                else if (product == "pineapple")
                    Console.WriteLine(5.50 * quantity);
                else if (product == "grapes")
                    Console.WriteLine(3.85 * quantity);
                else
                    Console.WriteLine("error");
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (product == "banana")
                    Console.WriteLine(2.70 * quantity);
                else if (product == "apple")
                    Console.WriteLine(1.25 * quantity);
                else if (product == "orange")
                    Console.WriteLine(0.90 * quantity);
                else if (product == "grapefruit")
                    Console.WriteLine(1.60 * quantity);
                else if (product == "kiwi")
                    Console.WriteLine(3.00 * quantity);
                else if (product == "pineapple")
                    Console.WriteLine(5.60 * quantity);
                else if (product == "grapes")
                    Console.WriteLine(4.20 * quantity);
                else
                    Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
