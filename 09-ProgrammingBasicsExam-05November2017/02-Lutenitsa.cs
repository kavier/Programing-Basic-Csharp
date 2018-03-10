using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoes = double.Parse(Console.ReadLine());
            double boxesInTruck = double.Parse(Console.ReadLine());
            double jarsInBoxes = double.Parse(Console.ReadLine());

            double producedLutenica = tomatoes / 5;
            double jars = producedLutenica / 0.535;
            double boxes = jars / jarsInBoxes;
            producedLutenica = Math.Floor(producedLutenica);

            Console.WriteLine($"Total lutenica: {producedLutenica} kilograms.");

            boxesInTruck = Math.Floor(boxesInTruck);
            jarsInBoxes = Math.Floor(jarsInBoxes);

            if (boxes < boxesInTruck)
            {
                double variable = boxesInTruck - boxes;
                double variable2 = (boxesInTruck * jarsInBoxes) - jars;
                variable = Math.Floor(variable);
                variable2 = Math.Floor(variable2);
                Console.WriteLine($"{variable} more boxes needed.");
                Console.WriteLine($"{variable2} more jars needed.");
                
            }
            else
            {
                double variable = boxes- boxesInTruck;
                double variable2 = jars- (boxesInTruck * jarsInBoxes);
                variable = Math.Floor(variable);
                variable2 = Math.Floor(variable2);
                Console.WriteLine($"{variable} boxes left.");
                Console.WriteLine($"{variable2} jars left.");
            }
        }
    }
}
