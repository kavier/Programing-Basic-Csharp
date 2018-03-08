using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1Meter = double.Parse(Console.ReadLine());

            double additionalTime1 = distance / 15;
            additionalTime1 = Math.Floor(additionalTime1);
            double additionalTime2 = additionalTime1 * 12.5;
            double ivanchoTime1 = distance * timeFor1Meter;
            double ivanchoTime = ivanchoTime1 + additionalTime2;

            if (ivanchoTime>=record)
            {
                Console.WriteLine($"No, he failed! He was {ivanchoTime - record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:f2} seconds.");

            }

        }
    }
}
