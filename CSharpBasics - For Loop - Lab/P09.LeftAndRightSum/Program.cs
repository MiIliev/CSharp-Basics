using System;

namespace P09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersLimit = int.Parse(Console.ReadLine());
            int sumFirstSet = 0;
            int sumSecondSet = 0;

            for (int i = 0; i < numbersLimit; i++)
            {
                int numberAdded = int.Parse(Console.ReadLine());
                sumFirstSet += numberAdded;
            }
            for (int i = 0; i < numbersLimit; i++)
            {
                int numberAdded = int.Parse(Console.ReadLine());
                sumSecondSet += numberAdded;
            }
            if (sumFirstSet == sumSecondSet)
            {
                Console.WriteLine($"Yes, sum = {sumFirstSet}");
            }
            else
            {
                int difference = Math.Abs(sumFirstSet- sumSecondSet);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
