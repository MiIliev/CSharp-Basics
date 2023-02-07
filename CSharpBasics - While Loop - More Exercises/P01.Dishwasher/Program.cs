using System;

namespace P01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            int detergentRemaining = detergentBottles * 750;
            int cycleCounter = 1;
            int washedPlatesCounter = 0;
            int washedPotsCounter = 0;
            string input = null;
            while ((input = Console.ReadLine()) != "End")
            {
                int dishes = int.Parse(input);
                int detergentUsed = 0;
                switch (cycleCounter)
                {
                    case 3:
                        detergentUsed = dishes * 15;
                        washedPotsCounter += dishes;
                        cycleCounter = 1;
                        break;
                    default:
                        detergentUsed = dishes * 5;
                        washedPlatesCounter += dishes;
                        cycleCounter++;
                        break;
                }
                detergentRemaining -= detergentUsed;
                if (detergentRemaining < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergentRemaining)} ml. " +
                        $"more necessary!");
                    break;
                }

            }
            if (detergentRemaining >= 0)
            {
                Console.WriteLine($"Detergent was enough!\n" +
                    $"{washedPlatesCounter} dishes and {washedPotsCounter} pots were washed.\n" +
                    $"Leftover detergent {detergentRemaining} ml.");
            }
        }
    }
}
