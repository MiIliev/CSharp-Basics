using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            for (hours = 0; hours < 24; hours++)
            {
                for (minutes = 0; minutes < 60; minutes++)
                {
                    for (seconds = 0; seconds < 60; seconds++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {seconds}");
                    }
                }
            }
        }
    }
}