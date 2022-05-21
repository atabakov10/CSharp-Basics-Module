using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int counttabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());


            //double restsalary = 0;

            for (int n = 0; n < counttabs; n++)
            {
                string website = Console.ReadLine();


                switch (website)
                {


                    case "Facebook":

                        salary = salary - 150;
                        break;



                    case "Instagram":

                        salary = salary - 100;
                        break;

                    case "Reddit":

                        salary = salary - 50;
                        break;
                }


            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
