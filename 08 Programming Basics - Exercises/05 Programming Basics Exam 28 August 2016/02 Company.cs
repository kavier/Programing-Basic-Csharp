using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double employees = double.Parse(Console.ReadLine());

            double workingHours = (days*0.9);
            double extraTime = employees * 2 * days;
            double subResult = Math.Floor(workingHours*8 + extraTime);

            if (subResult >= hours)
            {
                Console.WriteLine($"Yes!{subResult - hours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hours - subResult} hours needed.");

            }
        }
    }
}
