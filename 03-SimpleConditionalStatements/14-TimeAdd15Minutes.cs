using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int x = hour * 60;
            int s = x + minutes;
            int a = s / 60;
            int b = s - (a * 60) + 15;

            if (b<=59)
            {
                b = b;
            }
            else if (b>59)
            {
                a++;
                b = b - 60;
            }

            if (a<24)
            {
                a = a;
            }
            else if (a>=24)
            {
                a = a - 24;
            }
            Console.WriteLine("{0}:{1:00}", a, b);
        }
    }
}
