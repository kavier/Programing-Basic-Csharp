using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHight = int.Parse(Console.ReadLine());

            int cake = cakeWidth * cakeHight;
            int ostatak = 0;
            int pieces1 = 0;

            for (int i = 0; i < cake; i++)
            {
                string a = Console.ReadLine().ToLower();

                if (a != "stop")
                {
                    int pieces = int.Parse(a);
                    pieces1 += pieces;
                    ostatak = cake - pieces1;

                    if (ostatak < 0)
                    {
                        break;
                    }


                }
                else
                {
                    Console.WriteLine($"{ostatak} pieces are left.");
                    return;
                }
            }

            if (ostatak >= 0)
            {
                Console.WriteLine($"{ostatak} pieces are left.");
            }
            else if (ostatak < 0)
            {
                ostatak = Math.Abs(ostatak);
                Console.WriteLine($"No more cake left! You need {ostatak} pieces more.");
            }
        }
    }
}
