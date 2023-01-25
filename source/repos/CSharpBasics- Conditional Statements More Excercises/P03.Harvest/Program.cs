using System;

namespace P03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSqM = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double AllHarvest = grapesPerSqM * area;
            double grapesForWine = AllHarvest * 0.4;
            double wineProduced = grapesForWine / 2.5;

            if (wineNeeded <= wineProduced)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineProduced - wineNeeded)} liters left -> {Math.Ceiling((wineProduced - wineNeeded) / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - wineProduced)} liters wine needed.");
            }
        }
    }
}
