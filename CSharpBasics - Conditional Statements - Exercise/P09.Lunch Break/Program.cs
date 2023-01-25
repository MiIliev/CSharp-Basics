using System;

namespace P09.Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesTitle = Console.ReadLine();
            int seriesDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());
            double lunchDuration = breakDuration * 0.125;
            double restDuration = breakDuration * 0.25;
            double totalTimeNeeded = seriesDuration + lunchDuration + restDuration;

            if (totalTimeNeeded <= breakDuration) 
            {
                Console.WriteLine($"You have enough time to watch {seriesTitle} and left with {Math.Ceiling(breakDuration - totalTimeNeeded)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesTitle}, you need {Math.Ceiling(totalTimeNeeded - breakDuration)} more minutes.");
            }
        }
    }
}
