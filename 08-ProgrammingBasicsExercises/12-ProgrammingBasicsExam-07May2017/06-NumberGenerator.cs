using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int i = m; i > 0; i--)
            {
                for (int j = n; j > 0; j--)
                {
                    for (int k = l; k > 0; k--)
                    {
                        int mnl = i * 100 + j * 10 + k;
                        if (mnl%3==0)
                        {
                            specialNumber += 5;
                        }
                        else if (k==5)
                        {
                            specialNumber -= 2;
                        }
                        else if (mnl%2==0)
                        {
                            specialNumber *= 2;
                        }
                        if (specialNumber>=controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine($"No! {specialNumber} is the last reached special number.");

        }
    }
}
