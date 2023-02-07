using System;

namespace P02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int collectedMoney = 0;

            double cashSum = 0;
            int cashPaymentsCounter = 0;
            double cardSum = 0;
            int cardPaymentsCounter = 0;

            bool cardPayment = false;
            string input = null;
            while ((input = Console.ReadLine()) != "End" && goal >= collectedMoney)
            {
                int sale = int.Parse(input);
                switch (cardPayment)
                {
                    case true:
                        if (sale < 10)
                        {
                            Console.WriteLine("Error in transaction!");
                            cardPayment = false;
                        }
                        else
                        {
                            Console.WriteLine("Product sold!");
                            collectedMoney += sale;
                            cardSum += sale;
                            cardPaymentsCounter++;
                            cardPayment = false;
                        }
                        break;
                    case false:
                        if (sale > 100)
                        {
                            Console.WriteLine("Error in transaction!");
                            cardPayment = true;
                        }
                        else
                        {
                            Console.WriteLine("Product sold!");
                            collectedMoney += sale;
                            cashSum += sale;
                            cashPaymentsCounter++;
                            cardPayment = true;
                        }
                        break;
                }
                if (goal <= collectedMoney)
                {
                    break;
                }
            }
            double cashAverage = cashSum / cashPaymentsCounter;
            double cardAverage = cardSum / cardPaymentsCounter;

            if (goal <= collectedMoney)
            {
                Console.WriteLine($"Average CS: {cashAverage:f2}\n" +
                    $"Average CC: {cardAverage:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
