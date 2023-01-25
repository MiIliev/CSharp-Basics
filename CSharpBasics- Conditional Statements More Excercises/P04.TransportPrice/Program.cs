using System;

namespace P04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxiPriceDay = 0.7 + 0.79 * kilometers;
            double taxiPriceNight = 0.7 + 0.9 * kilometers;
            double busPrice = 0.09 * kilometers;
            double trainPrice = 0.06 * kilometers;
            if (time == "day" && kilometers < 20)
            {
                Console.WriteLine($"{taxiPriceDay:f2}");
            }
            else if (time == "night" && kilometers < 20)
            {
                Console.WriteLine($"{taxiPriceNight:f2}");
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                Console.WriteLine($"{busPrice:f2}");
            }
            else
            {
                Console.WriteLine($"{trainPrice:f2}");
            }
        }
    }
}
