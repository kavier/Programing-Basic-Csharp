using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inherit = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double razhodi = inherit;

            for (int i = year; i >= 1800; i--)
            {
                if (i % 2 != 0)
                {
                    double promenliva = 12000 + 50 * (18 + (i - 1800));
                    razhodi-=promenliva;
                }
                else
                {
                    razhodi -= 12000;
                }
            }

                if (razhodi<0)
                {
                    Console.WriteLine($"He will need {razhodi*(-1):f2} dollars to survive.");
                }
                else
                {
                    
                    Console.WriteLine($"Yes! He will live a carefree life and will have {razhodi:f2} dollars left.");

                }
        }
    }
}
