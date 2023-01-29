using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCargo = int.Parse(Console.ReadLine());
            int sumTons = 0;
            double busTons = 0;
            double lorryTons = 0;
            double trainTons = 0;
            int busPrice = 0;
            int lorryPrice = 0;
            int trainPrice = 0;

            for (int i = 0; i < countCargo; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                sumTons += tons;
                if (tons <= 3)
                {
                    busPrice += tons * 200;
                    busTons += tons;
                }
                else if (tons >=4 && tons <= 11) 
                {
                    lorryPrice += tons * 175;
                    lorryTons += tons;
                }
                else if (tons >= 12)
                {
                    trainPrice += tons * 120;
                    trainTons += tons;
                }
            }

            double totalPrice = busPrice + lorryPrice + trainPrice;
            double averagePrice = totalPrice / sumTons;
            Console.WriteLine($"{averagePrice:f2}");

            double percentageBus = busTons / sumTons * 100;
            double percentageLorry = lorryTons / sumTons * 100;
            double percentageTrain = trainTons / sumTons * 100;
            Console.WriteLine($"{percentageBus:f2}%");
            Console.WriteLine($"{percentageLorry:f2}%");
            Console.WriteLine($"{percentageTrain:f2}%");

        }
    }
}
