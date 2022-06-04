using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlannerPOE
{
    class Rental : Expense
    {
        private static double RentalAmount;

        //empty method
        public static void rental()
        {

        }
        
        //override method of the abstract class to print the rental
        public override double monthlyExp()
        {
            //request input from user
            Console.WriteLine("Please enter the monthly rental amount?");
            RentalAmount = double.Parse(Console.ReadLine());

            return RentalAmount;//return the value inserted
        }

        


    }
}
