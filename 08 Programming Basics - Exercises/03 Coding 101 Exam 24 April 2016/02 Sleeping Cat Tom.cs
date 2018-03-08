using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int daysVacation = days * 127;
            int workDays = (365 - days)*63;

            int playTime = workDays + daysVacation;

            var hours = 0;
            var minutes = 0;


            if (playTime >= 30000)
            {
                var diff = playTime - 30000;
                hours = diff / 60;
                minutes = diff - (hours * 60);
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            
            else
            {
                var diff = 30000 - playTime;
                hours = diff / 60;
                minutes = diff - (hours * 60);
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        } 
    }
}
