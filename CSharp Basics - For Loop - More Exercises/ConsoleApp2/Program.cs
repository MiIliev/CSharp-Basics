using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            int countGradePoor = 0;
            int countGradeFair = 0;
            int countGradeGood = 0;
            int countGradeVeryGood = 0;
            double sumGrades = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrades += grade;
                if (grade >= 2 && grade <= 2.99)
                {
                    countGradePoor++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    countGradeFair++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    countGradeGood++;
                }
                else if (grade >= 5 && grade <= 6)
                {
                    countGradeVeryGood++;
                }
            }
            double averageGrade = sumGrades / studentsCount;
            double percentageTopStudents = countGradeVeryGood / studentsCount * 100;
            double percentageGoodStudents = countGradeGood / studentsCount * 100;
            double percentageFairStudents = countGradeFair / studentsCount * 100;
            double percentagePoorStudents = countGradePoor / studentsCount * 100;

            Console.WriteLine($"Top students: {percentageTopStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentageGoodStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentageFairStudents:f2}%");
            Console.WriteLine($"Fail: {percentagePoorStudents:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}