using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double time1 = double.Parse(Console.ReadLine());
            double time2 = double.Parse(Console.ReadLine());
            double time3 = double.Parse(Console.ReadLine());

            double distance1 = speed * (time1/60);
            double distance2 = (speed * 1.1) * (time2 / 60);
            double distance3 = ((speed * 1.1) * 0.95) * (time3 / 60);

            double answer = distance1 + distance2 + distance3;

            Console.WriteLine($"{answer:f2}");
        }
    }
}
