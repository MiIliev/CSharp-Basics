using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            int daysSpendingCounter = 0;
            int daysPassed = 0;

            while (moneyNeeded > moneyAvailable && daysSpendingCounter < 5)
            {
                string action = Console.ReadLine();
                double actionedMoney = double.Parse(Console.ReadLine());
                daysPassed++;

                if (action == "spend")
                {
                    daysSpendingCounter++;
                    moneyAvailable -= actionedMoney;
                    if (moneyAvailable <0)
                    {
                        moneyAvailable = 0;
                    }
                }
                else if (action == "save")
                {
                    daysSpendingCounter = 0;
                    moneyAvailable += actionedMoney;
                }
            }

            if (moneyNeeded <= moneyAvailable)
            {
                Console.WriteLine($"You saved the money for {daysPassed} days.");
            }
            else if (daysSpendingCounter == 5)
            {
                Console.WriteLine($"You can't save the money.\n" +
                    $"{daysPassed}");
            }

        }
    }
}
