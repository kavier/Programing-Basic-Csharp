using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int totalExam = examHour * 60 + examMinutes;
            int totalArrival = arrivalHour * 60 + arrivalMinutes;

            var result = totalArrival - totalExam;
            var onTime = totalExam - totalArrival;

            int hours = result / 60;
            int min = result % 60;

            if (totalExam < totalArrival)
            {
                Console.WriteLine("Late");
                if (hours == 0)
                {
                      Console.WriteLine($"{min} minutes after the start");
                }
                else
                {

                    if (min < 10)
                        Console.WriteLine($"{hours}:0{min} hours after the start");
                    else
                        Console.WriteLine($"{hours}:{min} hours after the start");
                }
            }
            else if (onTime <= 30)
            {
                Console.WriteLine("On time");
                min = onTime % 60;

                if (onTime == 0)
                {

                }
                else
                    Console.WriteLine($"{min} minutes before the start");
            }

            else if (onTime > 30)
            {
                Console.WriteLine("Early");

                hours = onTime / 60;
                min = onTime % 60;

                if (hours == 0)
                {
                    if (min < 10)
                        Console.WriteLine($"0{min} minutes before the start");
                    else
                        Console.WriteLine($"{min} minutes before the start");
                }

                else
                {
                    if (min < 10)
                        Console.WriteLine($"{hours}:0{min} hours before the start");
                    else
                        Console.WriteLine($"{hours}:{min} hours before the start");
                }
            }

        }
    }
}