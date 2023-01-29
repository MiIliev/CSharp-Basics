using System;

namespace P02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;
            int difference = 0;

            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxNumber)
                    maxNumber = number;
            }
            if (sum - maxNumber == maxNumber)
                Console.WriteLine($"Yes\nSum = {sum - maxNumber}");
            else
            {
                difference = Math.Abs((sum - maxNumber) - maxNumber);
                Console.WriteLine($"No\nDiff = {Math.Abs(difference)}");
            }
        }
    }
}
