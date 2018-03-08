using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            double cups = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double work1 = days * workers;

            double work2 = work1 * 8.00;

            double work =Math.Floor(work2/5);

            if (work>=cups)
            {
                double extraMoney = (work - cups) * 4.2;
                Console.WriteLine($"{extraMoney:f2} extra money");

            }
            else
            {
                double losses = (cups - work) * 4.2;
                Console.WriteLine($"Losses: {losses:f2}");
            }
        }
    }
}
