using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dailyPayment = double.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            double monthly = workDays * dailyPayment;
            double yearly = 12 * monthly + 2.5 * monthly;
            double taxes = yearly * 0.25;
            double netoSalaryUS = yearly - taxes;
            double salary = netoSalaryUS * rate;

            double answer = salary / 365;

            Console.WriteLine($"{answer:f2}");
        }
    }
}
