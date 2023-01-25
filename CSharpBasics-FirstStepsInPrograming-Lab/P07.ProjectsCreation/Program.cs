using System;

namespace P07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int hoursSum = projectCount * 3;
            Console.WriteLine($"The architect {name} will need {hoursSum} hours to complete {projectCount} project/s.");
        }
    }
}
