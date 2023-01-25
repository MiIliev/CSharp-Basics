using System;

namespace P03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            int allFlowersCount = chrysanthemumsCount + rosesCount + tulipsCount;
            double chrysanthemumPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            double bouquetPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumPrice = 2 * chrysanthemumsCount;
                rosesPrice = 4.1 * rosesCount;
                tulipsPrice = 2.5 * tulipsCount;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumPrice = 3.75 * chrysanthemumsCount;
                rosesPrice = 4.5 * rosesCount;
                tulipsPrice = 4.15 * tulipsCount;
            }

            if (holiday == 'Y')
            {
                tulipsPrice *= 1.15;
                rosesPrice *= 1.15;
                chrysanthemumPrice *= 1.15;
            }

            bouquetPrice = tulipsPrice + rosesPrice + chrysanthemumPrice;

            if (tulipsCount > 7 && season == "Spring")
                bouquetPrice *= 0.95;
            if (rosesCount >= 10 && season == "Winter")
                bouquetPrice *= 0.9;
            if (allFlowersCount > 20)
                 bouquetPrice *= 0.8;

            Console.WriteLine($"{2 + bouquetPrice:f2}");
        }
    }
}
