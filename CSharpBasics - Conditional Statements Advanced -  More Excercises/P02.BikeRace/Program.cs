using System;

namespace P02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniour = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typeOfRace = Console.ReadLine();

            double collectedSum = 0;

            switch (typeOfRace)
            {
                case "trail":
                    collectedSum = juniour * 5.50 + seniors * 7;
                    break;
                case "cross-country":
                    if (juniour + seniors >= 50)
                        collectedSum = (juniour * 8 + seniors * 9.50) * 0.75;
                    else
                        collectedSum = juniour * 8 + seniors * 9.50;
                    break;
                case "downhill":
                    collectedSum = juniour * 12.25 + seniors * 13.75;
                    break;
                case "road":
                    collectedSum = juniour * 20 + seniors * 21.50;
                    break;
            }

            double expenses = collectedSum * 0.05;
            Console.WriteLine($"{collectedSum - expenses:f2}");
        }
    }
}
