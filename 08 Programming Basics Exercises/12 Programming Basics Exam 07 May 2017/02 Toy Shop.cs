using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha22
{
    class Program
    {
        static void Main(string[] args)
        {
            var travel = double.Parse(Console.ReadLine());
            var puzzles = double.Parse(Console.ReadLine());
            var dolls = double.Parse(Console.ReadLine());
            var tedies = double.Parse(Console.ReadLine());
            var minions = double.Parse(Console.ReadLine());
            var trucks = double.Parse(Console.ReadLine());

            var amount = (puzzles * 2.60) + (dolls * 3) + (tedies * 4.10) + (minions * 8.20) + (trucks * 2);

            var toys = puzzles + dolls + tedies + minions + trucks;

            if (toys >= 50)
            {
                var discount = amount * 0.25;
                var total = amount - discount;
                var rent = total * 0.1;
                var profit = total - rent;

                if (profit >= travel)
                {
                    var left = profit - travel;
                    Console.WriteLine("Yes! {0:f2} lv left.", left);
                }
                else
                {
                    var left = travel - profit;
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", left);
                }

            }
            else
            {
                var total = amount;
                var rent = total * 0.1;
                var profit = total - rent;

                if (profit >= travel)
                {
                    var left = profit - travel;
                    Console.WriteLine("Yes! {0:f2} lv left.", left);
                }
                else
                {
                    var left = travel - profit;
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", left);
                }
            }
        }
    }
}
