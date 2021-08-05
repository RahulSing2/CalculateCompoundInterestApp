using System;
using CompoundInterestLibrary;

namespace CalculateCompoundInterestApp
{   //C# program to calculate the compound interest.
    class Program
    {
        public static void  Main(string[] args)
        {   
            int years = 0;
            int annualCompound = 0;
            double roi = 0;
            double amount = 0;
            Console.WriteLine(DateTime.Now);  //Using a NuGet Package
            Console.Write("Enter the amount : ");
            amount = double.Parse(Console.ReadLine());

            Console.Write("Enter the rate of interest : ");
            roi = double.Parse(Console.ReadLine()); //roi is rate of interest

            Console.Write("Enter the total number of years : ");
            years = int.Parse(Console.ReadLine());

            Console.Write("Compounding frequency : ");
            annualCompound = int.Parse(Console.ReadLine());
            CompoundLibrary obj = new CompoundLibrary();
            obj.CalculateCompoundInterest(amount, roi, years, annualCompound);
            
        }

    }
}

