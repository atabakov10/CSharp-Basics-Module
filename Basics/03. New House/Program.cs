using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //            цвете Роза    Далия Лале    Нарцис Гладиола
            //Цена на брой в лева 5   3.80    2.80    3   2.50
            const double priceOfRoses = 5;
            const double priceofDahlias = 3.80;
            const double priceOfTulips = 2.80;
            const double priceOfNarcissus = 3;
            const double priceOfGladiolus = 2.50;

            string flowerType = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double finalMoney = 0;
            
            //⦁	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //⦁	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //⦁	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            switch (flowerType)
            {
                case "Roses":
                    if (countOfFlowers > 80)
                    {
                        finalMoney -= countOfFlowers * priceOfRoses * 0.10;
                    }
                    finalMoney += countOfFlowers * priceOfRoses;
                    break;
                case "Dahlias":
                    if (countOfFlowers > 90)
                    {
                        finalMoney -= countOfFlowers * priceofDahlias * 0.15;
                    }
                    finalMoney += countOfFlowers * priceofDahlias;
                    break;
                case "Tulips":
                    if (countOfFlowers > 80)
                    {
                        finalMoney -= countOfFlowers * priceOfTulips * 0.15;
                    }
                    finalMoney += countOfFlowers * priceOfTulips;
                    break;
                case "Narcissus":
                    if (countOfFlowers < 120)
                    {
                        finalMoney += countOfFlowers * priceOfNarcissus + 0.15;
                    }
                    finalMoney += countOfFlowers * priceOfNarcissus;
                    break;
                case "Gladiolus":
                    if (countOfFlowers < 80)
                    {
                        finalMoney += countOfFlowers * priceOfGladiolus * 0.20;
                    }
                    finalMoney += countOfFlowers * priceOfGladiolus;
                    break;
            }


            //            ⦁	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //⦁	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
            if (budget >= finalMoney)
            {
                double moneyLeft = budget - finalMoney;
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flowerType} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = finalMoney - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }




        }
    }
}
