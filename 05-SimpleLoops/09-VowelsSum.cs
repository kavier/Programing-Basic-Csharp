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
            var word = Console.ReadLine();
            var x = 0;
            for (int i = 0; i < word.Length; i++)

                switch (word[i])
                {
                    case 'a': x += 1; break;
                    case 'e': x += 2; break;
                    case 'i': x += 3; break;
                    case 'o': x += 4; break;
                    case 'u': x += 5; break;
                }

            Console.WriteLine(x);
        }
    }
}