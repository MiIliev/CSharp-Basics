using System;

namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = null;
            double expenses = 0;
            string accomodation = "Hotel";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        expenses = budget * 0.3;
                        break;
                    case "winter":
                        expenses = budget * 0.7;
                        break;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        expenses = budget * 0.4;
                        break;
                    case "winter":
                        expenses = budget * 0.8;
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                expenses = budget * 0.9;
            }

            if (season == "summer" && destination != "Europe")
                accomodation = "Camp";
            
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {expenses:f2}");
        }
    }
}
