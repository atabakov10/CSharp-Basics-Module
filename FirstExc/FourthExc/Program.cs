using System;

namespace FourthExc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            

            //Actions
            //Reverse the username

            string username = Console.ReadLine();
            string password = string.Empty;
            for (int reverseIndex = username.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                password += username[reverseIndex];
            }
            for (int count = 1; count <= 4; count++)
            {
                string enteredPassword = Console.ReadLine();
                if (enteredPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        continue;
                    }
                }
            }


            //Output
        }
    }
}
