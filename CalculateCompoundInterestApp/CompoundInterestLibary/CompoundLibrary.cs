using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundInterestLibrary
{
   public  class  CompoundLibrary
    {  
        public void CalculateCompoundInterest(double amount, double roi, int years, int annualCompound)
        {
            double result = 0;
            int loop = 0;
            if ((amount > 100 && roi > 0) && (years >0))
            {
                for (loop = 1; loop <= years; loop++)
                {
                    result = amount * Math.Pow((1 + roi / annualCompound), (annualCompound * loop));
                    Console.WriteLine("Your amount after {0} Year " + ": {1}", loop, result);
                }
            }
            else
            {
                Console.WriteLine("Amount should be greater than 100 and Rate of interest and years should be greater than 1");
            }
        }
   }
}

