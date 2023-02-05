using System;
using System.Transactions;

namespace P03.CalculatorDeposits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Sum: ");
            double depositSum = double.Parse(Console.ReadLine());
            Console.Write("Enter Deposit Term: ");
            double depositTerm = double.Parse(Console.ReadLine());
            Console.Write("Enter Interest Rate: ");
            double interestRate = double.Parse(Console.ReadLine());
            double interestRatePercentage = interestRate / 100;
            double totalSum = depositSum + depositTerm * ((depositSum * interestRatePercentage)/12);
            Console.WriteLine(totalSum);
        }
    }
}
