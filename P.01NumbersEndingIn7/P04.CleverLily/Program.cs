using System;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerCost = double.Parse(Console.ReadLine());
            double toyCost = double.Parse(Console.ReadLine());
            double moneyGifted = 10;
            double moneySaved = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += moneyGifted - 1;
                    moneyGifted += 10;
                }
                else
                {
                    moneySaved += toyCost;
                }
            }
            if (moneySaved >= washerCost)
                Console.WriteLine($"Yes! {moneySaved - washerCost:f2}");
            else
                Console.WriteLine($"No! {washerCost - moneySaved:f2}");
        }
    }
}
