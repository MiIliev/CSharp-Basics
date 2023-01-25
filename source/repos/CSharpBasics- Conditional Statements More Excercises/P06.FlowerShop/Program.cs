using System;

namespace P06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double magnolia = double.Parse(Console.ReadLine()) * 3.25;
            double hyacinth = double.Parse(Console.ReadLine()) * 4;
            double rose = double.Parse(Console.ReadLine()) * 3.50;
            double cactus = double.Parse(Console.ReadLine()) * 8;
            double gift = double.Parse(Console.ReadLine());
            double sumOrder = (magnolia + hyacinth + rose + cactus) * 0.95;

            if (sumOrder >= gift)
            {
                Console.WriteLine($"She is left with {Math.Floor(sumOrder - gift)} leva.");
            }
            else 
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift - sumOrder)} leva.");
            }
        }
    }
}
