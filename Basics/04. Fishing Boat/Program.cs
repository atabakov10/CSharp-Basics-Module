using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceForSpring = 3000;
            const double priceForSummerAndAutumn = 4200;
            const double priceForWinter = 2600;
            // инпут
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countOfFisherman = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            //logic
            //"Spring", "Summer", "Autumn", "Winter"
            switch (season)
            {
                case "Winter":
                    totalMoney = priceForWinter;
                    break;
                case "Spring":
                    totalMoney = priceForSpring;
                    break;
                case "Summer":
                case "Autumn":
                    totalMoney = priceForSummerAndAutumn;
                    break;

            }
            if (countOfFisherman <= 6)
            {
                totalMoney -= totalMoney * 0.10;
            }
            else if (countOfFisherman <= 11)
            {
                totalMoney -= totalMoney * 0.15;
            }
            else
            {
                totalMoney -= totalMoney * 0.25;
            }
            if (countOfFisherman % 2 == 0 && season != "Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }
            //output on the console aft solving the problem
            if (budget >= totalMoney)
            {
                double moneyLeft = budget - totalMoney; 
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalMoney - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }

            //            ⦁	Цената за наем на кораба през пролетта е  3000 лв.
            //⦁	Цената за наем на кораба през лятото и есента е  4200 лв.
            //⦁	Цената за наем на кораба през зимата е  2600 лв.
            //            В зависимост от броя си групата ползва отстъпка:
            //⦁	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //⦁	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //⦁	Ако групата е от 12 нагоре  –  отстъпка от 25 %.

        }
    }
}
