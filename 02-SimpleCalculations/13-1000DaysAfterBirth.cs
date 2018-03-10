using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime actualDate = DateTime.ParseExact(date, format, null);
            actualDate = actualDate.AddDays(999);
            Console.WriteLine(actualDate.ToString(format));
        }
    }
}
