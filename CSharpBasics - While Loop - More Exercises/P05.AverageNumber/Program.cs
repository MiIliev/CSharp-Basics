using System;

namespace P05.AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double numberSum = 0;
            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numberSum += number;
            }
            Console.WriteLine($"{numberSum / length:f2}");
        }
    }
}
