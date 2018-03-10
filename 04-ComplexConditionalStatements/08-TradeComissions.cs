using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha08
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double comission = 0;


            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = 0.05;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.07;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.08;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (10000 < sales)
                {
                    comission = 0.12;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = 0.045;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.075;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.10;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (10000 < sales)
                {
                    comission = 0.13;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = 0.055;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.08;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.12;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else if (10000 < sales)
                {
                    comission = 0.145;
                    double x = sales * comission;
                    Console.WriteLine("{0:f2}", x);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
            }
    }
