using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadionCapacity = double.Parse(Console.ReadLine());
            int fens = int.Parse(Console.ReadLine());
            double sectorA = 0.0;
            double sectorB = 0.0;
            double sectorV = 0.0;
            double sectorG = 0.0;

            for (int i = 0; i < fens; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }

            }

            Console.WriteLine($"{sectorA / fens * 100:f2}%");
            Console.WriteLine($"{sectorB / fens * 100:f2}%");
            Console.WriteLine($"{sectorV / fens * 100:f2}%");
            Console.WriteLine($"{sectorG / fens * 100:f2}%");
            Console.WriteLine($"{fens / stadionCapacity * 100:f2}%");

        }
    }
}
