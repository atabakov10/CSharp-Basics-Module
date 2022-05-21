using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int poinstWon = 0;
            int tournamentsWon = 0;
            for (int i = 0; i < tournamentsCount; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    poinstWon += 2000;
                    tournamentsWon++;
                }
                else if (result == "F")
                {
                    poinstWon += 1200;

                }
                else if (result == "SF")
                {
                    poinstWon += 720;
                }

            }
            Console.WriteLine($"Final points: {startPoints + poinstWon}");
            int averagePoins = poinstWon / tournamentsCount;
            Console.WriteLine($"Average points: {averagePoins}");
            double percentageToursWon = (double)tournamentsWon / tournamentsCount * 100;
            Console.WriteLine($"{percentageToursWon:f2}%");
        }
    }
}
