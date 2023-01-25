using System;

namespace P04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double costPuzzle = 2.60;
            double costDoll = 3;
            double costTeddyBear = 4.10;
            double costMinion = 8.20;
            double costTruck = 2;
            double costTrip = double.Parse(Console.ReadLine());
            int amountPuzzle = int.Parse(Console.ReadLine());
            int amountDoll = int.Parse(Console.ReadLine());
            int amountTeddyBear = int.Parse(Console.ReadLine());
            int amountMinion = int.Parse(Console.ReadLine());
            int amountTruck = int.Parse(Console.ReadLine());
            int amountAllToys = amountPuzzle + amountDoll + amountTeddyBear + amountMinion + amountTruck;

            double valuePuzzles = costPuzzle * amountPuzzle;
            double valueDolls = costDoll * amountDoll;
            double valueTeddyBears = costTeddyBear * amountTeddyBear;
            double valueMinions = costMinion * amountMinion;
            double valueTrucks = costTruck * amountTruck;
            double valueTotal = valuePuzzles + valueDolls + valueTeddyBears + valueMinions + valueTrucks;

            if (amountAllToys >= 50)
            {
                valueTotal = valueTotal * 0.75;
            }

            if (costTrip > (valueTotal * 0.9))
            {
                Console.WriteLine($"Not enough money! {(Math.Abs(costTrip - (valueTotal*0.9))):f2} lv needed.");
            }
            else 
            {
                Console.WriteLine($"Yes! {(valueTotal * 0.9 - costTrip):f2} lv left.");
            }
        }
    }
}
