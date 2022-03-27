using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double futureValue = 0;

            Console.Write("Enter monthly investment: ");
            double monthlyInvestement = double.Parse(Console.ReadLine());

            Console.Write("Enter yearly interest rate: ");
            double yearlyInterestRate = double.Parse(Console.ReadLine()) / 12 / 100;

            Console.Write("Enter number of years: ");
            double numOfYears = double.Parse(Console.ReadLine()) * 12;

            for (int i=0; i<numOfYears; i++)
            {
                futureValue = (futureValue + monthlyInvestement) * (1 + yearlyInterestRate);
            }

            Console.WriteLine("");
            Console.WriteLine("Future value: " + futureValue.ToString("C"));


            Console.WriteLine("monthly invest: " + monthlyInvestement);
            Console.WriteLine("monthly interest rate: " + yearlyInterestRate);
            Console.WriteLine("number of monthes: " + numOfYears);

            Console.ReadLine();
            

           
        }
    }
}
