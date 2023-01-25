using System;

namespace P03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sumNoDiscount = 0;
            double sumTotal = 0;

             switch (flowerType)
            {
                case "Roses":
                    sumNoDiscount = quantity * 5;
                    sumTotal = sumNoDiscount;
                    break;
                case "Dahlias":
                    sumNoDiscount = quantity * 3.8;
                    sumTotal = sumNoDiscount;
                    break;
                case "Tulips":
                    sumNoDiscount = quantity * 2.8;
                    sumTotal = sumNoDiscount;
                    break;
                case "Narcissus":
                    sumNoDiscount = quantity * 3;
                    sumTotal = sumNoDiscount;
                    break;
                case "Gladiolus":
                    sumNoDiscount = quantity * 2.5;
                    sumTotal = sumNoDiscount;
                    break;
            }

            if (flowerType == "Roses" && quantity > 80)
            {
                sumTotal -= sumNoDiscount * 0.1;
            }
            else if (flowerType == "Dahlias" && quantity > 90)
            {
                sumTotal -= sumNoDiscount * 0.15;
            }
            else if (flowerType == "Tulips" && quantity > 80)
            {
                sumTotal -= sumNoDiscount * 0.15;
            }
            else if (flowerType == "Narcissus" && quantity < 120)
            {
                sumTotal *= 1.15;
            }
            else if (flowerType == "Gladiolus" && quantity < 80)
            {
                sumTotal *= 1.2;
            }

            if (budget >= sumTotal)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {budget - sumTotal:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sumTotal - budget:f2} leva more.");
            }    
        }
    }
}
