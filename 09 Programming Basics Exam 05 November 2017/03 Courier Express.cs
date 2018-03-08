using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double parcelWeight = double.Parse(Console.ReadLine());
            string parcelType = Console.ReadLine();
            double parcelDistance = double.Parse(Console.ReadLine());
            double price = 0.0;
            double experessPrice = 0.0;

            if (parcelType == "standard")
            {
                if (parcelWeight < 1)
                {
                    price = 0.03;
                }
                else if (parcelWeight < 10)
                {
                    price = 0.05;

                }
                else if (parcelWeight < 40)
                {
                    price = 0.10;

                }
                else if (parcelWeight < 90)
                {
                    price = 0.15;

                }
                else if (parcelWeight < 150)
                {
                    price = 0.20;

                }
            }
            else if (parcelType == "express")
            {
                if (parcelWeight < 1)
                {
                    price = 0.03;
                    experessPrice = 0.8;

                }
                else if (parcelWeight < 10)
                {
                    price = 0.05;
                    experessPrice = 0.4;

                }
                else if (parcelWeight < 40)
                {
                    price = 0.10;
                    experessPrice = 0.05;

                }
                else if (parcelWeight < 90)
                {
                    price = 0.15;
                    experessPrice = 0.02;

                }
                else if (parcelWeight < 150)
                {
                    price = 0.20;
                    experessPrice = 0.01;

                }
            }

            double a = (parcelDistance * price);
                double b = ((experessPrice * price) * parcelWeight) * parcelDistance;
            double result = a + b;
            

            Console.WriteLine($"The delivery of your shipment with weight of {parcelWeight:f3} kg. would cost {result:f2} lv.");
        }
    }
}
