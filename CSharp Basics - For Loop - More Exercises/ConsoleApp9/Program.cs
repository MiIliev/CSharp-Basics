using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            bool isOdd = true;

            for (int i = 0; i < length; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (isOdd == false)
                {
                    // Code for Even numbers
                    evenSum += number;
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    isOdd = true;
                }
                else
                {
                    // Code for Odd numbers
                    oddSum += number;
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    isOdd = false;
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin != double.MaxValue )
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
