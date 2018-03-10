using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha9
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            if (userInput != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }

        }
    }
}
