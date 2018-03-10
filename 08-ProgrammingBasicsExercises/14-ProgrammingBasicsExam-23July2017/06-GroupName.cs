using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine().ToLower());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int count = 0;

            for (char i = 'a'; i <= a; i++)
            {
                for (char j = 'a'; j <= b; j++)
                {
                    for (char k = 'a'; k <= c; k++)
                    {
                        for (char l = 'a'; l <= d; l++)
                        {
                            for (int m = 0; m <= e; m++)
                            {
                                count++;
                               
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{count-1}");
        }
    }
}
