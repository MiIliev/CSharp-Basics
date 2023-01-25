using System;

namespace P04.VacationBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many pages are there in the book? ");
            int pageCount = int.Parse(Console.ReadLine());
            Console.Write("How many pages can you read per hour? ");
            int readingSpeed = int.Parse(Console.ReadLine());
            Console.Write("How many days do you have to read the book? ");
            int daysLimit = int.Parse(Console.ReadLine());
            int totalTime = pageCount / readingSpeed;
            int hoursNeededPerDay = totalTime / daysLimit;
            Console.WriteLine(hoursNeededPerDay);
        }
    }
}
