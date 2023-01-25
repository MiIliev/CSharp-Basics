using System;

namespace P09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine()) - 1;
            string accomodationType = Console.ReadLine();
            string rating = Console.ReadLine();

            double roomPrice = 18 * nights;
            double apartmentPrice = 25 * nights;
            double presidentPrice = 35 * nights;

            double totalCost = 0;

            if (nights < 10)
            {
                switch (accomodationType)
                {
                    case "room for one person":
                        totalCost = roomPrice;
                        break;
                    case "apartment":
                        totalCost = apartmentPrice * 0.7;
                        break;
                    case "president apartment":
                        totalCost = presidentPrice * 0.9;
                        break;
                }
            }
            else if (nights >= 10 && nights <= 15)
            {
                switch (accomodationType)
                {
                    case "room for one person":
                        totalCost = roomPrice;
                        break;
                    case "apartment":
                        totalCost = apartmentPrice * 0.65;
                        break;
                    case "president apartment":
                        totalCost = presidentPrice * 0.85;
                        break;
                }
            }
            else if (nights > 15)
            {
                switch (accomodationType)
                {
                    case "room for one person":
                        totalCost = roomPrice;
                        break;
                    case "apartment":
                        totalCost = apartmentPrice * 0.5;
                        break;
                    case "president apartment":
                        totalCost = presidentPrice * 0.8;
                        break;
                }
            }
            if (rating == "positive")
                Console.WriteLine($"{totalCost * 1.25:f2}");
            else if (rating == "negative")
                Console.WriteLine($"{totalCost * 0.9:f2}");
        }
    }
}
