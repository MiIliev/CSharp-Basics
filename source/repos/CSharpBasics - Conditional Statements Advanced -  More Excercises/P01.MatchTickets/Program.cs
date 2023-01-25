using System;

namespace P01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double vip = 499.99 * people;
            double normal = 249.99 * people;
            double transport = 0;
            double totalCost = 0;


            if (people >= 1 && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = budget * 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = budget * 0.4;
            }
            else if (people >= 50)
            {
                transport = budget * 0.25;
            }

            switch (category)
            {
                case "VIP":
                    totalCost = vip + transport;
                    break;
                case "Normal":
                    totalCost = normal + transport;
                    break;
            }

            if (budget >= totalCost)
                Console.WriteLine($"Yes! You have {budget - totalCost:f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva.");
        }
    }
}
