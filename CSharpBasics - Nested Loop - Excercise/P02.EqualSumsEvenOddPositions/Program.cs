using System;

namespace P02.EqualSumsEvenOddPositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = firstNumber; currentNumber <= secondNumber; currentNumber++)
            {
                string currentNumberToString = currentNumber.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int position = 0; position < 6; position++) 
                {
                    int currentDigit = currentNumberToString[position];
                    if (position % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}
