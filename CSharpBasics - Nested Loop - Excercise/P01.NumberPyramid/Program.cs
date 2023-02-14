using System;
using System.Transactions;

namespace P01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= number; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    if (currentNumber > number)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
