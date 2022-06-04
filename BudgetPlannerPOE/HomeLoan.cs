using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlannerPOE
{
    class HomeLoan:Expense
    {
        //declaring variables used in the home loan class
        private double PurchasePrice;
        private double TotalDepo;
        private double InterestRate;
        private double MonthsToRepay;
        private double FinalCalc;

        //empty method
       private void loan()
        {

        }

        //override method that request input from user and then does a calc
        public override double monthlyExp()
        {
            //requesting input from the user for the home loan details
            Console.WriteLine("Please enter the purchase price of the property: ");
            PurchasePrice = double.Parse(Console.ReadLine());

            //requesting input from the user for the home loan details
            Console.WriteLine("Please enter the total deposit for the property: ");
            TotalDepo = double.Parse(Console.ReadLine());

            //requesting input from the user for the home loan details
            Console.WriteLine("Please enter the Interest rate in percentage: ");
            InterestRate = double.Parse(Console.ReadLine());

            //requesting input from the user for the home loan details
            Console.WriteLine("Please enter the number of months required to repay, it must be somewhere between 240 and" +
                " 360 months: ");
            MonthsToRepay = double.Parse(Console.ReadLine());

            Console.WriteLine("Monthly home loan is being calculated...");

            //Declaring Variables 
            double Pcalc = (PurchasePrice - TotalDepo);//calc for the p value

            double Icalc = (InterestRate / 100);//calc for the interest in dec also known as i in calc

            double Ncalc = (MonthsToRepay / 12);//calc to display n in years

            double Tcalc = Pcalc * (1 + Icalc * Ncalc);//calc for the total price of the property using A=P(1+i*n)

            double FinalCalc = Tcalc / MonthsToRepay;//calc to work out the monthly cost of the home

            //thread sleep for 3 sec to give it time to do the neccesary calculations
            Thread.Sleep(3000);


            return FinalCalc;//returning the final calc of the method;

        }

        //method to check if the bank will aprove the loan
        public void ApprovalCheck(double MonthlyIncome)
        {
            
            //if else statement to verify if the home loan is more than a third of the gross income
            if (FinalCalc > monthlyThird(MonthlyIncome))
            {
                
                //turning the back ground color from black to red for the error message
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                //if it is display error message
                Console.WriteLine("Warning! Your Home loan payment is more than a third of your monthly income." +
                    "Its is highly unlike that the bank will grant you this loan.");

                //turning color back to blaack and white
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        //method to devide monthly income into a third
        public static double monthlyThird(double MonthlyIncome)
        {
            //calc
            double Third = MonthlyIncome / 3;

            return Third;//return the value
        }

    }
}
