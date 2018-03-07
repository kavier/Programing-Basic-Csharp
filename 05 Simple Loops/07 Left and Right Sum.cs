using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;

            for (int i = 0; i < n; i++)
            {
                left = left + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                right = right + int.Parse(Console.ReadLine());
            }
            if (left == right)
                Console.WriteLine("yes sum " + (left + right)/2);
            else
                Console.WriteLine("no diff " + Math.Abs(left - right));
        }
    }
}
