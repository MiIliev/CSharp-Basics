using System;

namespace P02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string account = Console.ReadLine();
            string password = Console.ReadLine();

            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password);
            Console.WriteLine($"Welcome {account}!");
        }
    }
}
