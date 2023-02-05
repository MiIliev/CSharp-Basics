using System;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowMarksLimit = int.Parse(Console.ReadLine());
            int lowMarksCounter = 0;
            int problemsCounter = 0;
            string input = null;
            double sumMarks = 0;
            string lastProblem = null;

            while (lowMarksCounter < lowMarksLimit)
            {
                input = Console.ReadLine();
                if (input == "Enough")
                {
                    double averageScore = sumMarks / problemsCounter;
                    Console.WriteLine($"Average score: {averageScore:f2}\n" +
                        $"Number of problems: {problemsCounter}\n" +
                        $"Last problem: {lastProblem}");
                    break;
                }

                double mark = double.Parse(Console.ReadLine());

                if (mark <= 4)
                {
                    lowMarksCounter++;
                }
                problemsCounter++;
                sumMarks += mark;
                lastProblem = input;
            }
            if (lowMarksCounter == lowMarksLimit)
            {
                Console.WriteLine($"You need a break, {lowMarksLimit} poor grades.");
            }
        }
    }
}
