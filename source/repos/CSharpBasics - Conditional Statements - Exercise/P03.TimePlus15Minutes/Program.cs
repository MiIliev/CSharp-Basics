using System;

namespace P03.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputHours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());
            string minutes;
            string hours;

            // hours calculations
            if (inputHours == 23 && inputMinutes >= 45)
            {
                hours = "0";
            }
            else if (inputHours < 23 && inputMinutes >= 45)
            {
                hours = $"{inputHours + 1}";
            }
            else 
            {
                hours = $"{inputHours}";
            }

            //minutes calculations
            if (inputMinutes > 45 && inputMinutes < 54)
            {
                minutes = $"0{inputMinutes + 15 - 60}";
            }
            else if (inputMinutes > 54)
            {
                minutes = $"{inputMinutes + 15 - 60}";
            }
            else if (inputMinutes == 45)
            {
                minutes = "00";
            }
            else
            {
                minutes = $"{inputMinutes + 15}";
            }

            Console.WriteLine($"{hours}:{minutes}");            
        }
    }
}
