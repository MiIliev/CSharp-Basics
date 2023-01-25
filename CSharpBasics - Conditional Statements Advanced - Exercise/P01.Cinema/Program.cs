using System;

namespace P01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            int seats = row * column;
            double premiereCost = 12;
            double normalCost = 7.5;
            double discountCost = 5;

            switch (typeOfProjection)
            {
                case "Premiere":
                    Console.WriteLine($"{premiereCost * seats:f2} leva.");
                    break;
                case "Normal":
                    Console.WriteLine($"{normalCost * seats:f2} leva.");
                    break;
                case "Discount":
                    Console.WriteLine($"{discountCost * seats:f2} leva.");
                    break;
            }
        }
    }
}
