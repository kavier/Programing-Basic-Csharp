using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < min)
                    min = currentNumber;
            }
            Console.WriteLine(min);
        }
    }
}
