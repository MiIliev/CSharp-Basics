using System;

namespace P02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            if (temperature >= 10 && temperature <= 18)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        Console.WriteLine($"It's {temperature} degrees, get your Sweatshirt and Sneakers.");
                        break;
                    case "Afternoon":
                    case "Evening":
                        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
            else if (temperature >= 19 && temperature <= 24)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                    case "Evening":
                        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                        break;
                }
            }
            else if (temperature > 24)
            {
                switch (timeOfDay)
                {
                    case "Morning":
                        Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {temperature} degrees, get your Swim Suit and Barefoot.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
        }
    }
}
