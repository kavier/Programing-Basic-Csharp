using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double topStudents = 0.0;
            double between4and5 = 0.0;
            double between3and4 = 0.0;
            double fail = 0.0;
            double sum = 0.0;


            for (int i = 0; i < n; i++)
            {

                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    topStudents++;
                }
                else if (grade >= 4)
                {
                    between4and5++;
                }
                else if (grade >= 3)
                {
                    between3and4++;
                }
                else
                {
                    fail++;
                }

                sum += grade;

            }

            Console.WriteLine($"Top students: {topStudents / n * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4and5 / n * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3and4 / n * 100:f2}%");
            Console.WriteLine($"Fail: {fail / n * 100:f2}%");
            Console.WriteLine($"Average: {sum / n:f2}");

        }
    }
}
