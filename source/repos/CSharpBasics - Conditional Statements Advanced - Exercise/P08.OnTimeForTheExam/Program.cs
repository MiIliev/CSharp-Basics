using System;

namespace P08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = hour * 60 + minutes;
            int arrivalTime = arrivalHour * 60 + arrivalMinutes;
            int differenceMinutes = Math.Abs((arrivalTime - examTime) % 60);
            double _differenceHours = (Math.Abs((examTime - arrivalTime) / 60));
            double differenceHours = Math.Floor(_differenceHours);

            bool late = arrivalTime > examTime;
            bool early = arrivalTime < (examTime - 30);
            bool onTime = arrivalTime == examTime;
            bool onTime30mins = arrivalTime < examTime && examTime - arrivalTime <= 30;

            if (onTime)
            {
                Console.WriteLine("On time");
            }
            else if (late)
            {
                Console.WriteLine("Late");
                if (differenceHours == 0)
                    Console.WriteLine($"{differenceMinutes} minutes after the start");
                else
                    Console.WriteLine($"{differenceHours}:{differenceMinutes:d2} hours after the start");
            }
            else if (early)
            {
                Console.WriteLine("Early");
                if (differenceHours == 0)
                    Console.WriteLine($"{differenceMinutes} minutes before the start");
                else
                    Console.WriteLine($"{differenceHours}:{differenceMinutes:d2} hours before the start");
            }
            else if (onTime30mins)
            {
                Console.WriteLine("On time");
                if (differenceHours == 0)
                    Console.WriteLine($"{differenceMinutes} minutes before the start");
                else
                    Console.WriteLine($"{differenceHours}:{differenceMinutes:d2} hours before the start");
            }
        }
    }
}




