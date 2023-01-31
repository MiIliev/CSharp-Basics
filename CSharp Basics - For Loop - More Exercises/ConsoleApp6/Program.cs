using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());
            bool firstPair = true;
            bool allPairsEqual = true;
            double previousPair = 0;
            double maxDifference = double.MinValue;
            double sumAB = 0;

            for (int i = 0; i < pairsCount; i++)
            {
                double numberA = double.Parse(Console.ReadLine());
                double numberB = double.Parse(Console.ReadLine());
                sumAB = numberA + numberB;
                if (firstPair == true)
                {
                    previousPair = sumAB;
                    firstPair = false;
                }
                else
                {
                    if (sumAB != previousPair)
                    {
                        double difference = Math.Abs(sumAB - previousPair);
                        if (difference > maxDifference)
                        {
                            maxDifference = difference;
                        }
                        previousPair = sumAB;
                    }
                }
            }

            if (maxDifference != double.MinValue)
            {
                allPairsEqual = false;
            }

            switch (allPairsEqual)
            {
                case true:
                    Console.WriteLine($"Yes, value={sumAB}");
                    break;
                case false:
                    Console.WriteLine($"No, maxdiff={maxDifference}");
                    break;
            }
        }
    }
}
