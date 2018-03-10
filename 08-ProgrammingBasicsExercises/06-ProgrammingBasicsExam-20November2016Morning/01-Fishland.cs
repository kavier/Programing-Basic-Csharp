using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSkumria = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double weightPalamud = double.Parse(Console.ReadLine());
            double weightSafrid = double.Parse(Console.ReadLine());
            double weightMidi = double.Parse(Console.ReadLine());

            double pricePalamud = priceSkumria * 1.6;
            double priceSafrid = priceCaca * 1.8;
            double priceMidi = 7.5;

            double sumPalamud = pricePalamud * weightPalamud;
            double sumSafrid = priceSafrid * weightSafrid;
            double sumMidi = priceMidi * weightMidi;

            double total = sumMidi + sumPalamud + sumSafrid;

            Console.WriteLine($"{total:f2}");
        }
    }
}
