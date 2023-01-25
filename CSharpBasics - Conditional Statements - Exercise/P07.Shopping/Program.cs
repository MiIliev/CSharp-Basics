using System;

namespace P07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int amountVRAM = int.Parse(Console.ReadLine());
            int amountCPU = int.Parse(Console.ReadLine());
            int amountRAM = int.Parse(Console.ReadLine());

            double costVRAM = 250 * amountVRAM;
            double costCPU = costVRAM * 0.35 * amountCPU;
            double costRAM = costVRAM * 0.1 * amountRAM;
            double totalCost = costVRAM + costCPU + costRAM;

            if (amountVRAM > amountCPU) 
            {
                totalCost = totalCost * 0.85;
            }

            if (budget >= totalCost)
            {
                Console.WriteLine($"You have {budget - totalCost:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva more!");
            }
        }
    }
}
