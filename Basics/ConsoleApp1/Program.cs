using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            //logic for solving the problem
            switch (timeOfDay)
            {
                case "Morning":
                    if (degrees <= 18)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");

                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");

                    }
                    else
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");

                    }
                    break;
                case "Afternoon":
                    if (degrees <= 18)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");

                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");

                    }
                    else
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");

                    }
                    break;

                case "Evening":

                    if (degrees <= 18)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");

                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");

                    }
                    else
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");

                    }

                    break;
            }

        }
    }
}
