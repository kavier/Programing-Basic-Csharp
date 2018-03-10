using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {
            double campaineDays = double.Parse(Console.ReadLine());
            double backers = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double biscuites = double.Parse(Console.ReadLine());
            double panecakes = double.Parse(Console.ReadLine());

            double cakePrice = 45.00;
            double biscuitesPrice = 5.80;
            double panecakesPrice = 3.20;

            double dailySum = ((cakePrice * cakes + biscuites * biscuitesPrice + panecakes * panecakesPrice) * backers) * campaineDays;

            double profit = dailySum - dailySum / 8;

            Console.WriteLine($"{profit:f2}");


        }
    }
}
