using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int accomodations = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1 ; floor--)
            {
                for (int accomodation = 0; accomodation < accomodations; accomodation++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{accomodation} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{accomodation} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{accomodation} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
