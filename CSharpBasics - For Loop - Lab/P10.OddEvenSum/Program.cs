using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace P10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine()); 
            int sumOdds = 0;
            int sumEvens = 0;
            int evenStep = 1;

            for (evenStep = evenStep; evenStep <= length; evenStep++)
            {
                if (evenStep % 2 == 0)
                {
                    int number = int.Parse(Console.ReadLine());
                    sumEvens += number;
                }
                else
                {
                    int number = int.Parse(Console.ReadLine());
                    sumOdds += number;
                }
            }
            if (sumEvens == sumOdds)
                Console.WriteLine($"Yes\nSum = {sumEvens}");
            else
                Console.WriteLine($"No\nDiff = {Math.Abs(sumEvens - sumOdds)}");
        }
    }
}
