using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double car = 0.0;
            double truck = 0.0;
            double smallBus = 0.0;
            double bigBus = 0.0;
            double train = 0.0;
            double people = 0.0;

            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());

                people += a;

                if(a>=41)
                {
                    train += a;
                }
                else if(a>=26)
                {
                    bigBus += a;
                }
                else if (a>=13)
                {
                    smallBus += a;
                }
                else if (a>=6)
                {
                    truck += a;
                }
                else
                {
                    car += a;
                }
            }
            double answer1 = car / people * 100;
            double answer2 = (truck / people) * 100;
            double answer3 = (smallBus / people) * 100;
            double answer4 = bigBus / people * 100;
            double answer5 = train / people * 100;

            Console.WriteLine($"{answer1:f2}%");
            Console.WriteLine($"{answer2:f2}%");
            Console.WriteLine($"{answer3:f2}%");
            Console.WriteLine($"{answer4:f2}%");
            Console.WriteLine($"{answer5:f2}%");

        }
    }
}
