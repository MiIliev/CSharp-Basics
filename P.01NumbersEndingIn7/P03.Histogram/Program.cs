using System;

namespace P03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double countBelow200 = 0;
            double count200To399 = 0;
            double count400To599 = 0;
            double count600To799 = 0;
            double countabove800 = 0;

            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                    countBelow200++;
                else if (number >= 200 && number <= 399)
                    count200To399++;
                else if (number >= 400 && number <= 599)
                    count400To599++;
                else if (number >= 600 && number <= 799)
                    count600To799++;
                else if (number >= 800 && number <= 1000)
                    countabove800++;
            }

            double percentageBelow200 = countBelow200 / length * 100;
            double percentage200To399 = count200To399/ length * 100;
            double percentage400To599 = count400To599/ length * 100;
            double percentage600To799 = count600To799/ length * 100;
            double percentageAbove800 = countabove800 / length * 100;

            Console.WriteLine($"{percentageBelow200:f2}%");
            Console.WriteLine($"{percentage200To399:f2}%");
            Console.WriteLine($"{percentage400To599:f2}%");
            Console.WriteLine($"{percentage600To799:f2}%");
            Console.WriteLine($"{percentageAbove800:f2}%");
        }
    }
}
