using System;

namespace P01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poolV = int.Parse(Console.ReadLine());
            double debitPipe1 = double.Parse(Console.ReadLine());
            double debitPipe2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double litersP1 = debitPipe1 * hours;
            double litersP2 = debitPipe2 * hours;
            double litersP12 = litersP1 + litersP2;

            if (litersP1 + litersP2 <= poolV)
            {
                Console.WriteLine($"The pool is {(litersP1 + litersP2)/poolV * 100:f2}% full. Pipe 1: {litersP1/litersP12 * 100:f2}%. Pipe 2: {litersP2/litersP12 *100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {litersP1 + litersP2 - poolV:f2} liters.");
            }
        }
    }
}
