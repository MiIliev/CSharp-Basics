using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            double primeNumbersSum = 0;
            double nonPrimeNumbersSum = 0;
            bool isPrime = true;
            while ((input = Console.ReadLine()) != "stop")
            {
                double number = double.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeNumbersSum += number;
                    }
                    else if(!isPrime)
                    {
                        nonPrimeNumbersSum += number;
                        isPrime = true;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");
        }
    }
}
