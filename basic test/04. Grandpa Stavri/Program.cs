using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double kol = 0;
        double gr = 0;
        double allKol = 0;
        double gradus = 0;
        double allGr = 0;
        double totalGr = 0;
        for (int i = 1; i <= n; i++)
        {
            kol = double.Parse(Console.ReadLine());
            gr = double.Parse(Console.ReadLine());
            gradus = kol * gr;
            allKol += kol;
            allGr += gradus;
        }
        totalGr = allGr / allKol;
        Console.WriteLine("Liter: {0:f2}", allKol);
        Console.WriteLine("Degrees: {0:f2}", totalGr);
        if (totalGr < 38)
        {
            Console.WriteLine("Not good, you should baking!");
        }
        else if (totalGr >= 38 && totalGr <= 42)
        {
            Console.WriteLine("Super!");
        }
        else if (totalGr > 42)
        {
            Console.WriteLine("Dilution with distilled water!");
        }
    }
}

