using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPhotos = double.Parse(Console.ReadLine());
            string photoSize = Console.ReadLine().ToLower();
            string orderMethod = Console.ReadLine().ToLower();
            double discount = 1.0;
            double onlineDiscount = 1.0;
            double price = 0.0;

            if (photoSize == "9x13")
            {
                price = 0.16;

                if (numberOfPhotos >= 50)
                {
                    discount = 0.95;
                }
            }
            else if (photoSize == "10x15")
            {
                price = 0.16;
                if (numberOfPhotos>=80)
                {
                    discount = 0.97;
                }
            }
            else if (photoSize == "13x18")
            {
                price = 0.38;
                if (numberOfPhotos > 100)
                {
                    discount = 0.95;
                }
                else if (numberOfPhotos >= 50)
                {
                    discount = 0.97;
                }
            }
            else if (photoSize == "20x30")
            {
                price = 2.90;
                if (numberOfPhotos>50)
                {
                    discount = 0.91;
                }
                else if (numberOfPhotos>=10)
                {
                    discount = 0.93;
                }
            }

            switch(orderMethod)
            {
                case "online":
                    onlineDiscount = 0.98;
                    break;
            }

            double result = ((numberOfPhotos * price) * discount) * onlineDiscount;

            Console.WriteLine($"{result:f2}BGN");
        }
    }
}
