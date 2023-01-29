using System;

namespace P02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= length; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }

                    int todaysPatients = int.Parse(Console.ReadLine());
                    if (todaysPatients <= doctors)
                    {
                        treatedPatients += todaysPatients;
                    }
                    else
                    {
                        untreatedPatients += todaysPatients - doctors;
                        treatedPatients += doctors;
                    }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
