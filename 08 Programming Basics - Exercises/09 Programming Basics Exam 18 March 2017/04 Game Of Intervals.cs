using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double invalidNumbers = 0;
            double from0to9 = 0;
            double from10to19 = 0;
            double from20to29 = 0;
            double from30to39 = 0;
            double from40to50 = 0;
            double points = 0;

            for (int i = 0; i < n; i++)
            {
                double move = double.Parse(Console.ReadLine());

                if (move > 50 || move < 0)
                {
                    invalidNumbers++;
                    points = points/2;

                }
                else if (move >= 40)
                {
                    from40to50++;
                    points +=100;

                }
                else if (move >= 30)
                {
                    from30to39++;
                    points += 50;

                }
                else if(move>=20)
                {
                    from20to29++;
                    double promenliva = move * 0.4;
                    points += promenliva;

                }
                else if (move>=10)
                {
                    from10to19++;
                    double promenliva = move * 0.3;
                    points += promenliva;

                }
                else if (move>=0)
                {
                    from0to9++;
                    double promenliva = move * 0.2;
                    points += promenliva;

                }
            }

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {from0to9/n*100:f2}%");
            Console.WriteLine($"From 10 to 19: {from10to19/n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {from20to29/n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {from30to39/n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {from40to50/n * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers/n * 100:f2}%");

        }
    }
}
