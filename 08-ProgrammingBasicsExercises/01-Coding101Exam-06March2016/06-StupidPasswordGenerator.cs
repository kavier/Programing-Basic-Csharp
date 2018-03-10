using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha07_stupid_password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            var pass = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char c = 'a'; c <'a'+ l; c++)
                    {
                        for (char d = 'a'; d < 'a' + l; d++)
                        {
                            var max = Math.Max(i, j);

                            for (int p = max +1; p <= n; p++)
                            {
                                pass = string.Format("{0}{1}{2}{3}{4} ", i, j, c, d, p);

                                Console.Write(pass);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
