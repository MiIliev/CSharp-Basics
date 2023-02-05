using System;

namespace P01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookSearched = Console.ReadLine();
            int booksChecked = 0;
            bool bookFound = false;
            string book = Console.ReadLine();
            while (book != "No More Books")
            {
                if (book == bookSearched)
                {
                    Console.WriteLine($"You checked {booksChecked} books and found it.");
                    break;
                }
                booksChecked++;
                book = Console.ReadLine();
            }
            if (book == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!\nYou checked {booksChecked} books.");
            }

        }
    }
}
