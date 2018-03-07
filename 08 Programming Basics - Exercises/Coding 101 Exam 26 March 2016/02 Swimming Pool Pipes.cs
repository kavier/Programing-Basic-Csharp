using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = double.Parse(Console.ReadLine());
            var p1 = double.Parse(Console.ReadLine());
            var p2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var result = 1.0;
            var pipe1perc = 1.0;
            var pipe2perc = 1.0;
            var pipe1 = p1 * h;
            var pipe2 = p2 * h;
            

            var totalPipes = pipe1 + pipe2;

            if (totalPipes <= v)
            {
                result = (totalPipes*100) / v;
                pipe1perc = (pipe1*100) / totalPipes;
                pipe2perc = (pipe2*100) / totalPipes;

                result = Math.Floor(result);
                pipe1perc = Math.Floor(pipe1perc);
                pipe2perc = Math.Floor(pipe2perc);

                Console.WriteLine($"The pool is {result}% full. Pipe 1: {pipe1perc}%. Pipe 2: {pipe2perc}%.");
            }
            else
            {
                result = totalPipes - v;
                Console.WriteLine($"For {h} hours the pool overflows with {result:f1} liters.");

            }
        }
    }
}