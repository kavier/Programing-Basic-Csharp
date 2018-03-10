using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double daysToLearn = double.Parse(Console.ReadLine());

            double result = (steps / daysToLearn) / steps *100;
            result = Math.Ceiling(result);

            double stepsForDancer = result / dancers;

            if (result <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsForDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsForDancer:f2}% steps to be learned per day.");

            }
        }
    }
}
