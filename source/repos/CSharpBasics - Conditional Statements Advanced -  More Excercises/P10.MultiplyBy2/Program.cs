using System;

namespace P10.MultiplyBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            while (number >= 0)
            {
                number = double.Parse(Console.ReadLine());
                if (number < 0)
                    Console.WriteLine("Negative number!");
                else
                    Console.WriteLine($"Result: {number * 2:f2}");
            }
        }
    }
}
