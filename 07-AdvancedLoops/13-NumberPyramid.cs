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
            int n = int.Parse(Console.ReadLine());

            var number = 0;
            
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < i + 1; j++)
                {

                    number += 1;

                    Console.Write(number + " ");

                    if (number == n)
                        break;
                                    
                }

                if (number == n)
                    
                break;

                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
