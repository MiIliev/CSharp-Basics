using System;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double musalaClimbers = 0;
            double montBlancClimbers = 0;
            double kilimanjaroClimbers = 0;
            double kTwoClimbers = 0;
            double jomolungmaClimbers = 0;
            int totalClimbers = 0;

            for (int i = 0; i < groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());
                totalClimbers += climbers;
                if (climbers < 6)
                    musalaClimbers+= climbers;
                else if (climbers >= 6 && climbers <= 12)
                    montBlancClimbers += climbers;
                else if (climbers >= 13 && climbers <= 25)
                    kilimanjaroClimbers += climbers;
                else if (climbers >= 26 && climbers <= 40)
                    kTwoClimbers += climbers;
                else if (climbers >=41)
                    jomolungmaClimbers += climbers;
            }

            double percentageMusala = musalaClimbers / totalClimbers * 100;
            double percentageMontBlanc = montBlancClimbers/ totalClimbers * 100;
            double percentageKilimanjaro = kilimanjaroClimbers/ totalClimbers * 100;
            double percentageKTwo = kTwoClimbers/ totalClimbers * 100;
            double percentageJomolungma = jomolungmaClimbers/ totalClimbers * 100;

            Console.WriteLine($"{percentageMusala:f2}%");
            Console.WriteLine($"{percentageMontBlanc:f2}%");
            Console.WriteLine($"{percentageKilimanjaro:f2}%");
            Console.WriteLine($"{percentageKTwo:f2}%");
            Console.WriteLine($"{percentageJomolungma:f2}%");
        }
    }
}
