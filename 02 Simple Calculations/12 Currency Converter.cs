using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha12
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            decimal rate1 = 0m;
            decimal rate2 = 0m;

            if (b == "BGN")
            {
                rate1 = 1m;
            }
            else if (b == "USD")
            {
                rate1 = 1.79549m;
            }
            else if (b == "EUR")
            {
                rate1 = 1.95583m;
            }
            else if (b == "GBP")
            {
                rate1 = 2.53405m;
            }
            if (c == "BGN")
            {
                rate2 = 1m;
            }
            else if (c == "USD")
            {
                rate2 = 1.79549m;
            }
            else if (c == "EUR")
            {
                rate2 = 1.95583m;
            }
            else if (c == "GBP")
            {
                rate2 = 2.53405m;
            }
            decimal result = a * (rate1 / rate2 );

            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
