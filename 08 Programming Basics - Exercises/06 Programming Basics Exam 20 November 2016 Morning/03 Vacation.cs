using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double elderly = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();
            double priceElderly = 0.0;
            double priceStudents = 0.0;
            double discount = 1.0;
            double sleep = 82.99;

            switch(transport)
            {
                case "train":
                    priceElderly = 24.99;
                    priceStudents = 14.99;
                    break;
                case "bus":
                    priceElderly = 32.50;
                    priceStudents = 28.50;
                    break;
                case "boat":
                    priceElderly = 42.99;
                    priceStudents = 39.99;
                    break;
                case "airplane":
                    priceElderly = 70.00;
                    priceStudents = 50.00;
                    break;
            }

            if (students>=50 && transport == "train")
            {
                discount = 0.5;
                //priceStudents = priceStudents * discount;
            }
            else if (elderly >= 50 && transport == "train")
            {
                discount = 0.5;
                //priceElderly = priceElderly * discount;

            }

            double transportCost = (elderly * priceElderly + students * priceStudents) * 2 * discount;
            double hotelCost = nights * sleep;
            double commision = (transportCost + hotelCost) * 0.1;

            double result = transportCost + hotelCost + commision;

            Console.WriteLine($"{result:f2}");
        }
    }
}
