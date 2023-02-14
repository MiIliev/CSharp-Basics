using System;

namespace P06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            bool lastFloor = true;
            for (int floorCounter = floors; floorCounter >= 1; floorCounter--)
            {
                for (int roomCounter = 0; roomCounter < rooms; roomCounter++)
                {
                    if (lastFloor)
                    {
                        Console.Write($"L{floorCounter}{roomCounter}");
                        if (roomCounter == (rooms - 1))
                        {
                            lastFloor = false;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (floorCounter % 2 == 0)
                        {
                            Console.Write($"O{floorCounter}{roomCounter}");
                            if (roomCounter == (rooms -1))
                            {
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            Console.Write($"A{floorCounter}{roomCounter}");
                            if (roomCounter == (rooms - 1))
                            {
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }                   
                }
            }

        }
    }
}
