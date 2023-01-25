using System;

namespace P06.SwimmingWorldRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            double waterRes = (int)meters / 15 * 12.5; //seconds
            double ivansTime = meters * secondsPerMeter + waterRes;

            if (ivansTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {ivansTime - worldRecord:f2} seconds slower.");
            }
        }
    }
}
