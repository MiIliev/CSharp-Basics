using System;

namespace P04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double veggyPriceBGN = double.Parse(Console.ReadLine());
            double fruitPriceBGN = double.Parse(Console.ReadLine());
            double veggyWeight = double.Parse(Console.ReadLine());
            double fruitWeight = double.Parse(Console.ReadLine());
            double veggyPriceEUR = veggyPriceBGN / 1.94;
            double fruitPriceEUR = fruitPriceBGN / 1.94;
            double sumEUR = (veggyPriceEUR * veggyWeight) + (fruitPriceEUR * fruitWeight);
            Console.WriteLine(sumEUR.ToString("0.00"));
        }
    }
}
