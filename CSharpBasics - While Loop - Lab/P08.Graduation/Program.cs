using System;

namespace P08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int timesFailed = 0;
            double sumMarks = 0;
            while (grade < 13)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark < 4)
                {
                    timesFailed++;
                    if (timesFailed > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                sumMarks += mark;
                grade++;
            }
            if (grade == 13)
            {
                double averageMarks = sumMarks / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageMarks:f2}");
            }
        }
    }
}
