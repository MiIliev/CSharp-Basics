using System;

namespace P01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int death = int.Parse(Console.ReadLine());
            int age = 17;
            double moneyRemaining = inheritedMoney;

            for (int i = 1800; i <= death; i++)
            {
                if (i % 2 == 0)
                {
                    age++;
                    moneyRemaining -= 12000;
                }
                else
                {
                    age++;
                    moneyRemaining -= 12000 + 50 * age;
                }
            }

            if (moneyRemaining >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyRemaining:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyRemaining):f2} dollars to survive.");
            }
        }
    }
}
