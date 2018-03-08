using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int na = 0;
            int nb = 0;
            int nc = 0;
            int nd = 0;


            for (int a = 1; a <= 9; a++)
            {
                na = n % a;

                for (int b = 1; b <= 9; b++)
                {
                    nb = n % b;

                    for (int c = 1; c <= 9; c++)
                    {
                        nc = n % c;

                        for (int d = 1; d <= 9; d++)
                        {
                            nd = n % d;

                            if (na == 0)
                            {
                                A = a;
                                if (nb == 0)
                                {
                                    B = b;
                                    if (nc == 0)
                                    {
                                        C = c;

                                        if (nd == 0)
                                        {
                                            D = d;

                                            Console.Write($"{A}{B}{C}{D} ");

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
                 
            Console.WriteLine();
        }
    }
}
