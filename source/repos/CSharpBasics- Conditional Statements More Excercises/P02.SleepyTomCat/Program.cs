using System;

namespace P02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vacation = int.Parse(Console.ReadLine());
            int workDays = 365 - vacation;
            int timeToPlay = vacation * 127 + workDays * 63;
            int time = timeToPlay - 30000;

            if (timeToPlay > 30000)
            {
                int hours = time / 60;
                int minutes = time % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int hours = Math.Abs(time) / 60;
                int minutes = Math.Abs(time) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
