using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string c = Console.ReadLine();

            if (n2 != 0)
            {
                if (c == "/")
                {
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2:f2}");
                    
                }
                else if (c == "%")
                {
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");

                }
                else if (c == "+")
                {
                    if ((n1 + n2) % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2} - odd");

                    }
                }
                else if (c == "-")
                {
                    if ((n1 - n2) % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2} - odd");

                    }
                }
                else if (c == "*")
                {
                    if ((n1 * n2) % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2} - odd");

                    }
                }
            }
            else
            {
                Console.WriteLine($"Cannot divide {n1} by zero");

            }
        }
    }
}
