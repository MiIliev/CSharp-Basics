using System;

namespace P05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = null;
            while ((destination = Console.ReadLine() )!= "End")
            {
                double budget = double.Parse(Console.ReadLine());
                while (budget > 0)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    budget -= savedMoney;
                    if (budget <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
