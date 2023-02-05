using System;

namespace P06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = null;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
