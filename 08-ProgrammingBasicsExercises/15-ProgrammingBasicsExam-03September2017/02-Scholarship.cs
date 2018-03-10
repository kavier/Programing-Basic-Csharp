using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double lowestFare = double.Parse(Console.ReadLine());
            double social = lowestFare * 0.35;
            double excelence = grades * 25;
            social = Math.Floor(social);
            excelence = Math.Floor(excelence);

            if (income <= lowestFare && grades >= 5.5 && social <= excelence)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excelence:f0} BGN");

            }
            
            else if (income <= lowestFare && grades >= 4.5 && social < excelence)
            {
                Console.WriteLine($"You get a Social scholarship {social:f0} BGN");

            }
            else if (income <= lowestFare && grades >= 4.5 && social > excelence)
            {
                Console.WriteLine($"You get a Social scholarship {social:f0} BGN");
            }
            else if(grades >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excelence:f0} BGN");

            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");

            }
        }
    }
}
