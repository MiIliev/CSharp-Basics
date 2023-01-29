using System;

namespace P04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powerLimit = int.Parse(Console.ReadLine());

            for (int pow = 0; pow <= powerLimit; pow += 2)
            {
                Console.WriteLine(Math.Pow(2, pow));
            }
        }
    }
}
