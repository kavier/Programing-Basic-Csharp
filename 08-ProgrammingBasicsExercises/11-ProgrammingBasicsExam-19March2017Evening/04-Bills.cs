using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double months = double.Parse(Console.ReadLine());
            double electricityBill = 0.0;
            double otherBills = 0.0;

            for (int i = 0; i < months; i++)
            {
                double n = double.Parse(Console.ReadLine());

                double sum = (n + 20 + 15) * 1.2;

                electricityBill += n;
                otherBills += sum;
            }

            double waterBill = months * 20;
            double internerBill = months * 15;

            double average = (waterBill + internerBill + electricityBill + otherBills) / months;

            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internerBill:f2} lv");
            Console.WriteLine($"Other: {otherBills:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
