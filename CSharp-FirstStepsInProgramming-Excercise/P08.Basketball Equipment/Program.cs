using System;

namespace P08.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the annual cost? ")
            int annualPrice = int.Parse(Console.ReadLine());
            double shoes = annualPrice - (annualPrice * 0.4);
            double clothes = shoes - (shoes * 0.2);
            double ball = 0.25 * clothes;
            double accessories = 0.2 * ball;
            double Total = annualPrice + shoes + clothes + ball + accessories;
            Console.WriteLine(Total);
        }
    }
}
