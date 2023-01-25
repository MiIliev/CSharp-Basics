using System;

namespace P05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accomodation = null;
            string location = null;
            double price = budget;

            switch (season)
            {
                case "Summer":
                location = "Alaska";
                break;
            case "Winter":
                location = "Morocco";
                break;
            }


            if (price <= 1000)
            {
                accomodation = "Camp";
                if (season == "Summer")
                    price *= 0.65;
                else if (season == "Winter")
                    price *= 0.45;
            }
            else if (price > 1000 && price <= 3000)
            {
                accomodation = "Hut";
                if (season == "Summer")
                    price *= 0.80;
                else if (season == "Winter")
                    price *= 0.60;
            }
            else if (price > 3000)
            {
                accomodation = "Hotel";
                price *= 0.90;
            }
            Console.WriteLine($"{location} - {accomodation} - {price:f2}");
        }
    }
}
