using System;

namespace P06.ConcatinateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fName=Console.ReadLine();
            string lName=Console.ReadLine();
            string age=Console.ReadLine();
            string town=Console.ReadLine();
            Console.WriteLine($"You are {fName} {lName}, a {age}-years old person from {town}.");
        }
    }
}
