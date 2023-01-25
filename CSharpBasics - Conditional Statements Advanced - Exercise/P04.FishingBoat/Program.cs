using System;

namespace P04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double boatCost = 0;
            double cost = 0;

            switch (season)
            {
                case "Spring":
                    boatCost = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatCost = 4200;
                    break;
                case "Winter":
                    boatCost = 2600;
                    break;
            }

            if (fishermans <= 6)
                cost = boatCost * 0.9;
            else if (fishermans > 6 && fishermans <= 11)
                cost = boatCost * 0.85;
            else if (fishermans > 11)
                cost = boatCost * 0.75;

            if (fishermans % 2 == 0 && season != "Autumn")
                cost *= 0.95;

            if (budget >= cost)
                Console.WriteLine($"Yes! You have {budget - cost:f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {cost - budget:f2} leva.");
        }
    }
}
