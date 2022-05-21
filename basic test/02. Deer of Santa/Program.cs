using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDaysOut = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double foodForDayForFirstElenInKg = double.Parse(Console.ReadLine());
            double foodForDayForSecondElenInKg = double.Parse(Console.ReadLine());
            double foodForDayForThirdElenInKg = double.Parse(Console.ReadLine());
            double neededFoodForFirstElen = numDaysOut * foodForDayForFirstElenInKg;
            double neededFoodForSecondElen = numDaysOut * foodForDayForSecondElenInKg;
            double neededFoodForThirdElen = numDaysOut * foodForDayForThirdElenInKg;
            double totalNeededFood = neededFoodForFirstElen + neededFoodForSecondElen + neededFoodForThirdElen;
            double foodLeft = Math.Floor(foodLeftKg - totalNeededFood);
            double foodNeeded = Math.Ceiling(totalNeededFood - foodLeftKg);
            if (foodLeftKg > totalNeededFood)
            {
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else if (totalNeededFood > foodLeftKg)
            {
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
