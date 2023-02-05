using System;

namespace P05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double changeInCoins = change * 100;
            double remainingChange = changeInCoins;
            int coinsCount = 0;
            while (remainingChange > 0)
            {
                if (remainingChange >= 200)
                {
                    remainingChange -= 200;
                }
                else if (remainingChange >= 100)
                {
                    remainingChange -= 100;
                }
                else if (remainingChange >= 50)
                {
                    remainingChange -= 50;
                }
                else if (remainingChange >= 20)
                {
                    remainingChange -= 20;
                }
                else if (remainingChange >= 10)
                {
                    remainingChange -= 10;
                }
                else if (remainingChange >= 5)
                {
                    remainingChange -= 5;
                }
                else if (remainingChange >= 2)
                {
                    remainingChange -= 2;
                }
                else if (remainingChange >= 1)
                {
                    remainingChange -= 1;
                }
                else
                {
                    remainingChange = 0;
                    break;
                }
                coinsCount++;
            }
            Console.WriteLine(coinsCount);
        }
    }
}
