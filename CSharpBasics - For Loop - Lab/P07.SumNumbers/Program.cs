using System;

namespace P07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                int addedNumber = int.Parse(Console.ReadLine());
                sum += addedNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
