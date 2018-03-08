using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double jelev = 0.0;
            double RoYaL = 0.0;
            double Roli = 0.0;
            double Trofon = 0.0;
            double Sino = 0.0;
            double Others = 0.0;



            for (int i = 0; i < lectures; i++)
            {
                string a = Console.ReadLine().ToLower();
                if (a == "jelev")
                {
                    jelev++;
                }
                else if (a == "royal")
                {
                    RoYaL++;
                }
                else if (a =="roli")
                {
                    Roli++;
                }
                else if (a=="trofon")
                {
                    Trofon++;
                }
                else if (a=="sino")
                {
                    Sino++;
                }
                else
                {
                    Others++;
                }
            }
            double salary = budget / lectures;

            Console.WriteLine($"Jelev salary: {jelev * salary:f2} lv");
            Console.WriteLine($"RoYaL salary: {RoYaL * salary:f2} lv");
            Console.WriteLine($"Roli salary: {Roli * salary:f2} lv");
            Console.WriteLine($"Trofon salary: {Trofon * salary:f2} lv");
            Console.WriteLine($"Sino salary: {Sino * salary:f2} lv");
            Console.WriteLine($"Others salary: {Others * salary:f2} lv");

        }
    }
}
