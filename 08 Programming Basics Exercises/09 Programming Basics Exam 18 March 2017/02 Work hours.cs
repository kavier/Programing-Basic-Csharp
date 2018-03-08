using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());

            double work = workers * workDays * 8;

            if (work > hours)
            {
                Console.WriteLine($"{work - hours} hours left");
            }
            else
            {
                double sum = hours - work;
                Console.WriteLine($"{sum} overtime");
                Console.WriteLine($"Penalties: {sum*workDays}");

            }

        }
    }
}
