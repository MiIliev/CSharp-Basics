using System;

namespace P10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isValid = number == 0 || (number >= 100 && number <= 200);

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
