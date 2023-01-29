using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double totalScore = 0;
            double countInvalid = 0;
            double count0To9 = 0;
            double count10To19 = 0;
            double count20To29 = 0;
            double count30To39 = 0;
            double count40To50 = 0;

            for (int i = 0; i < length; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    countInvalid++;
                    totalScore /= 2;
                }
                else if (number >= 0 && number <= 9)
                {
                    count0To9++;
                    totalScore += number * 0.2;
                }
                else if (number >= 10 && number <= 19)
                {
                    count10To19++;
                    totalScore += number * 0.3;
                }
                else if (number >= 20 && number <= 29)
                {
                    count20To29++;
                    totalScore += number * 0.4;
                }
                else if (number >= 30 && number <= 39)
                {
                    count30To39++;
                    totalScore += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    count40To50++;
                    totalScore += 100;
                }
            }

            double percentageInvalid = countInvalid / length * 100;
            double percentage0To9 = count0To9 / length * 100;
            double percentage10To19 = count10To19 / length * 100;
            double percentage20To29 = count20To29 / length * 100;
            double percentage30To39 = count30To39 / length * 100;
            double percentage40To50 = count40To50 / length * 100;

            Console.WriteLine($"{totalScore:f2}");
            Console.WriteLine($"From 0 to 9: {percentage0To9:f2}%");
            Console.WriteLine($"From 10 to 19: {percentage10To19:f2}%");
            Console.WriteLine($"From 20 to 29: {percentage20To29:f2}%");
            Console.WriteLine($"From 30 to 39: {percentage30To39:f2}%");
            Console.WriteLine($"From 40 to 50: {percentage40To50:f2}%");
            Console.WriteLine($"Invalid numbers: {percentageInvalid:f2}%");
        }
    }
}
