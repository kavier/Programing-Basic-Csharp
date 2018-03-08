using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double poor = 0.0;
            double satisfactory = 0.0;
            double good = 0.0;
            double veryGood = 0.0;
            double excellent = 0.0;

            for (int i = 0; i < n; i++)
            {
                double grades = double.Parse(Console.ReadLine());

                if (grades <22.5)
                {
                    poor++;
                }
                else if (grades <40.5)
                {
                    satisfactory++;
                }
                else if (grades <58.5)
                {
                    good++;
                }
                else if (grades <76.5)
                {
                    veryGood++;
                }
                else if (grades <= 100)
                {
                    excellent++;
                }
            }
            Console.WriteLine($"{(poor/ n) * 100:f2}% poor marks");
            Console.WriteLine($"{(satisfactory/ n) * 100:f2}% satisfactory marks");
            Console.WriteLine($"{(good/ n) * 100:f2}% good marks");
            Console.WriteLine($"{(veryGood/ n) * 100:f2}% very good marks");
            Console.WriteLine($"{(excellent/ n) * 100:f2}% excellent marks");
        }
    }
}
