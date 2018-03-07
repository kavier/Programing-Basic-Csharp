using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha09
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i] - 48;
            }

            Console.WriteLine(sum);
        }
    }
}
