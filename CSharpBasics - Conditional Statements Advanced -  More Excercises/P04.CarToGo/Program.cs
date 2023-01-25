using System;

namespace P04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string classOfCar = null;
            string typeOfCar = null;

            if (budget <= 100)
            {
                classOfCar = "Economy class";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.35;
                        typeOfCar = "Cabrio";
                        break;
                    case "Winter":
                        price = budget * 0.65;
                        typeOfCar = "Jeep";
                        break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classOfCar = "Compact class";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.45;
                        typeOfCar = "Cabrio";
                        break;
                    case "Winter":
                        price = budget * 0.8;
                        typeOfCar = "Jeep";
                        break;
                }
            }
            else if (budget > 500)
            {
                classOfCar = "Luxury class";
                price = budget * 0.9;
                typeOfCar = "Jeep";
            }

            Console.WriteLine($"{classOfCar}");
            Console.WriteLine($"{typeOfCar} - {price:f2}");
        }
    }
}
