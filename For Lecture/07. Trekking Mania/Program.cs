using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupMusala = 0;
            int groupMonblan = 0;
            int groupKilimandjaro = 0;
            int groupK2 = 0;
            int groupEverest = 0;
            int n = int.Parse(Console.ReadLine());
            int totalPeopleCount = 0;

            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                totalPeopleCount += digit;
                if (digit <= 5)
                {
                    groupMusala += digit;
                }
                else if (digit <= 12)
                {
                    groupMonblan += digit;
                }
                else if (digit <= 25)
                {
                    groupKilimandjaro += digit;
                }
                else if (digit <= 40)
                {
                    groupK2 += digit;
                }
                else
                {
                    groupEverest += digit;
                }

            }
            double musalaPercentage, monblanPercentage, KilimandjaroPercentage, k2Percentage, everestPercentage;


            musalaPercentage = (double)groupMusala / totalPeopleCount * 100;
            monblanPercentage = (double)groupMonblan / totalPeopleCount * 100;
            KilimandjaroPercentage = (double)groupKilimandjaro / totalPeopleCount * 100;
            k2Percentage = (double)groupK2 / totalPeopleCount * 100;
            everestPercentage = (double)groupEverest / totalPeopleCount * 100;

            Console.WriteLine($"{musalaPercentage:f2}%");
            Console.WriteLine($"{monblanPercentage:f2}%");
            Console.WriteLine($"{KilimandjaroPercentage:f2}%");
            Console.WriteLine($"{k2Percentage:f2}%");
            Console.WriteLine($"{everestPercentage:f2}%");


        }



    }
}
