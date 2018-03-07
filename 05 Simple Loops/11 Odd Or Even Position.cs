using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var evenSum = 0.0;
            var oddMax = double.MinValue;
            var oddMin = double.MaxValue;
            var evenMax = double.MinValue;
            var evenMin = double.MaxValue;
 
 
            for (int i = 1; i <= number; i++)
            {
                var curentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += curentNumber;
                    if (curentNumber > evenMax)
                    {
                        evenMax = curentNumber;
                    }
                    if (curentNumber < evenMin)
                    {
                        evenMin = curentNumber;
                    }
                }
                else
                {
                    oddSum += curentNumber;
                    if (curentNumber > oddMax)
                    {
                        oddMax = curentNumber;
                    }
                    if (curentNumber < oddMin)
                    {
                        oddMin = curentNumber;
                    }
                }
 
            }
            Console.WriteLine("OddSum=" + oddSum);
 
            if (oddMin > 1000000000.0 || oddMin < -1000000000.0)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin);
            }
 
            if (oddMax > 1000000000.0 || oddMax < -1000000000.0)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax);
            }
 
 
            Console.WriteLine("EvenSum=" + evenSum);
 
            if (evenMin > 1000000000.0 || evenMin < -1000000000.0)
            {
                Console.WriteLine("EvenMin=No");
            } else
            {
                Console.WriteLine("EvenMin=" + evenMin);
            }
 
            if (evenMax > 1000000000.0 || evenMax < -1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }
    }
}