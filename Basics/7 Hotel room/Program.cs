using System;

namespace _7_Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mayAndOctomberStudioPrice = 50;
            const double mayAndOctomberApartmentPrice = 65;
            const double juneAndSeptemberStudioPrice = 75.20;
            const double juneAndSeptemberApartmentPrice = 68.70;
            const double julyAndAugustStudioPrice = 76;
            const double julyAndAugustApartmentPrice = 77;

            string season = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            double totalMoneyForStudio = 0;
            double totalMoneyForApartment = 0;

            switch (season)
            {
                case "May":
                case "October":
                    totalMoneyForStudio = night * mayAndOctomberStudioPrice;
                    totalMoneyForApartment = night * mayAndOctomberApartmentPrice;
                    if (night > 7 && night < 14)
                    {
                        totalMoneyForStudio -= totalMoneyForStudio * 0.05;
                    }
                    else if (night > 14)
                    {
                        totalMoneyForStudio -= totalMoneyForStudio * 0.3;
                    }
                    break;
                case "June":
                case "September":
                    totalMoneyForStudio = night * juneAndSeptemberStudioPrice;
                    totalMoneyForApartment = night * juneAndSeptemberApartmentPrice;
                    if (night > 14)
                    {
                        totalMoneyForStudio -= totalMoneyForStudio * 0.20;
                    }
                    break;
                case "July":
                case "August":
                    totalMoneyForStudio = julyAndAugustStudioPrice * night;
                    totalMoneyForApartment = julyAndAugustApartmentPrice * night;

                    break;
            }
            if (night > 14)
            {
                totalMoneyForApartment -= totalMoneyForApartment * 0.10;
            }
            Console.WriteLine($"Apartment: {totalMoneyForApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
            //⦁	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //⦁	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //⦁	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //⦁	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
            //⦁	На първия ред е месецът – May, June, July, August, September или October
            //⦁	На втория ред е броят на нощувките – цяло число в интервала[0... 200]


        }
    }
}
