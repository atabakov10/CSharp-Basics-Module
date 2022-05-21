using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double finalMoney = 0;
            //logic
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    finalMoney = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {finalMoney:f2}");
                }
                else
                {
                    finalMoney = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {finalMoney:f2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    finalMoney = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {finalMoney:f2}");
                }
                else
                {
                    finalMoney = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {finalMoney:f2}");
                }
            }
            else
            {
                finalMoney = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {finalMoney:f2}");
            }
        }

    }
}

