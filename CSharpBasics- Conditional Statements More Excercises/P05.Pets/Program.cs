using System;

namespace P05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine()) / 1000;
            double foodneeded = (dogFood + catFood + turtleFood) * days;

            if (foodneeded <= food)
            {
                Console.WriteLine($"{Math.Floor(food - foodneeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(Math.Abs(foodneeded - food))} more kilos are needed.");
            }
        }
    }
}
