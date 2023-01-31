using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int hours = 0;
            int minutes = 0;
            for (hours = 0; hours <= 23; hours++)
            {
                for (minutes = 0; minutes < 60; minutes++)
                {
                Console.WriteLine($"{hours} : {minutes}");
                }
                minutes = 0;
            }
        }
    }
}
