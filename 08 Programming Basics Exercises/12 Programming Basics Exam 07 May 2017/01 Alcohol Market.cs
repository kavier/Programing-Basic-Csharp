using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double brandyQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double brandyPrice = whiskeyPrice / 2;
            double winePrice = brandyPrice * 0.6;
            double beerPrice = brandyPrice * 0.2;

            double total = (brandyQuantity * brandyPrice) + (wineQuantity * winePrice) + (beerQuantity * beerPrice) + (whiskeyQuantity * whiskeyPrice);

            Console.WriteLine($"{total:f2}");
        }
    }
}
