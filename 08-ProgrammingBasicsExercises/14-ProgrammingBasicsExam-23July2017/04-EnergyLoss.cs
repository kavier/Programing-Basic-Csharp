using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            double energy = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double hours = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (hours % 2 == 0)
                    {
                        double promenliva = 68 * a;
                        energy += promenliva;
                    }
                    else
                    {
                        double promenliva = 65 * a;
                        energy += promenliva;
                    }
                }
                else
                {
                    if (hours % 2 == 0)
                    {
                        double promenliva = 49 * a;
                        energy += promenliva;
                    }
                    else
                    {
                        double promenliva = 30 * a;
                        energy += promenliva;
                    }
                }
            }

            double totalEnergy = 100 * n * a;
            double energyLeft = totalEnergy - energy;
            double dancerEnergy = energyLeft / n / a;

            if (dancerEnergy > 50)
            {
                Console.WriteLine($"They feel good! Energy left: {dancerEnergy:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {dancerEnergy:f2}");

            }
        }
    }
}

