using System;

namespace P05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            double total = 0;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double deposit = double.Parse(input);
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:f2}");
                total += deposit;
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
