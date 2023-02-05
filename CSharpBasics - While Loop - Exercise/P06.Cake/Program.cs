using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int allPieces = cakeWidth * cakeLength;
            int sumPiecesTaken = 0;

            while (sumPiecesTaken <= allPieces)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    int piecesTaken = int.Parse(input);
                    sumPiecesTaken += piecesTaken;
                }
            }

            int differencePieces = Math.Abs(sumPiecesTaken - allPieces);

            if (sumPiecesTaken < allPieces)
            {
                Console.WriteLine($"{differencePieces} pieces are left.");
            }
            else if (sumPiecesTaken >= allPieces)
            {
                Console.WriteLine($"No more cake left! You need {differencePieces} pieces more.");
            }
        }
    }
}
