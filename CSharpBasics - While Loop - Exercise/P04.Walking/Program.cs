using System;

namespace P04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumSteps = 0;

            while (sumSteps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int steps = int.Parse(Console.ReadLine());
                    sumSteps += steps;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    sumSteps += steps;
                }
            }

            int stepDifference = Math.Abs(sumSteps - 10000);

            if (sumSteps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!\n{stepDifference} steps over the goal!");
            }
            else if (sumSteps < 10000)
            {
                Console.WriteLine($"{stepDifference} more steps to reach goal.");
            }
        }
    }
}
