using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double fieldSize = double.Parse(Console.ReadLine());
            double kilosPerSQmeter = double.Parse(Console.ReadLine());
            double fira = double.Parse(Console.ReadLine());

            double dobiv = fieldSize * kilosPerSQmeter-fira;

            double brandy = (dobiv * 0.45)/7.5;
            double brandyIncome = brandy * 9.80;

            double grapeIncome = (dobiv * 0.55) * 1.50;

            Console.WriteLine($"{brandyIncome:f2}");
            Console.WriteLine($"{grapeIncome:f2}");

        }
    }
}
