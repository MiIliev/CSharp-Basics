using System;

namespace P03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int enteredNumber = 0;
            int sumNumber = 0;

            while (sumNumber < number)
            {
                enteredNumber = int.Parse(Console.ReadLine());
                sumNumber += enteredNumber;
            }
            Console.WriteLine(sumNumber);
        }
    }
}
