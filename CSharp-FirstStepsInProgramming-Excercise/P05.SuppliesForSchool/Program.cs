using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many pens? ");
            int pensCount = int.Parse(Console.ReadLine());
            Console.Write("How many markers? ");
            int markerCount = int.Parse(Console.ReadLine());
            Console.Write("How many liters of detergent? ");
            int detergentLiters = int.Parse(Console.ReadLine());
            Console.Write("What is the Discount Percentage? ");
            double percentageEntered = double.Parse(Console.ReadLine());
            double percentage = percentageEntered / 100;
            double materialsSum = (pensCount * 5.80) + (markerCount * 7.20) + (detergentLiters * 1.20);
            double totalSum = materialsSum - (percentage * materialsSum);
            Console.WriteLine(totalSum);
        }
    }
}
