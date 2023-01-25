using System;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dFoodCount = int.Parse(Console.ReadLine());
            int cFoodCount = int.Parse(Console.ReadLine());
            double dFoodPrice = 2.50;
            int cFoodPrice = 4;
            double dTotalCost = dFoodCount * dFoodPrice;
            int cTotalCost = cFoodCount * cFoodPrice;
            double totalCost = dTotalCost + cTotalCost;
            Console.WriteLine(totalCost + " lv.");
        }
    }
}
