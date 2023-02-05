using System;

namespace P07.Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chickens: ");
            int chicken = int.Parse(Console.ReadLine());
            Console.Write("Fish: ");
            int fish = int.Parse(Console.ReadLine());
            Console.Write("Vegetarian Meals: ");
            int veggy = int.Parse(Console.ReadLine());
            double orderPrice = chicken * 10.35 + fish * 12.40 + veggy * 8.15;
            double totalPrice = orderPrice * 0.2 + orderPrice + 2.50;
            Console.WriteLine(totalPrice);

        }
    }
}
