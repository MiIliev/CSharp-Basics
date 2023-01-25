using System;

namespace P05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double costClothing = double.Parse(Console.ReadLine());
            costClothing = costClothing * extras;
            double costDecor = budget * 0.1;

            if (extras > 150) 
            {
                costClothing = costClothing * 0.9;
            }

            if ((costDecor + costClothing) > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs((costDecor + costClothing) - budget):f2} leva more.");
            }
            else if ((costDecor + costClothing) <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - (costDecor + costClothing):f2} leva left.");
            }
        }
    }
}
