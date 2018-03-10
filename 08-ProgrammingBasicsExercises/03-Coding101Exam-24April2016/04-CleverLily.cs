using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double odds = 0;
            double even = 0;
            double brother = 0;
            double promenliva = 0;


            for (int i = 1; i <= age; i++)
            {

                if (i % 2 != 0)
                {
                    odds += 1;
                }
                else
                {
                    even += 10;
                    brother += 1;
                    promenliva += even;
                }
            }

            double toys = odds * toyPrice;
            double birthMoney = promenliva - brother;
            double sum = toys + birthMoney;

            if (sum >= washMachine)
            {
                Console.WriteLine($"Yes! {sum - washMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washMachine - sum:f2}");

            }
        }
    }
}
