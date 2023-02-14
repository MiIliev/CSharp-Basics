using System;
using System.Runtime.ConstrainedExecution;

namespace P04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentationName = null;
            double sumAllPresentation = 0;
            int presentationCounter = 0;
            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                double sumMark = 0;
                for (int i = 0; i < jury; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    sumMark += mark;
                }
                double averageMark = sumMark / jury;
                Console.WriteLine($"{presentationName} - {averageMark:f2}.");
                sumAllPresentation += averageMark;
                presentationCounter++;
            }
            double averageAllStudentsMark = sumAllPresentation / presentationCounter;
            Console.WriteLine($"Student's final assessment is {averageAllStudentsMark:f2}.");
        }
    }
}
