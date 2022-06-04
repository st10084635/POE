using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerPOE
{
    public abstract class Expense
    {
        //add it to expense collection
        private List<double> expenses = new List<double>();
        private double totalExp;

        //method that will populate the arrays for rent and home loan depending on which was chosen
        public void setExpenses(List<double> totalUserExp)
        {
            //so that the 1 list matches the other
            expenses = totalUserExp;
        }

        //method that will calculate the total expenses
        public double getExpenses()
        {
            //retrieves the total from list
            totalExp = expenses.Sum();

            return totalExp;
        }

        //abstract method that goes with abstract class
        public abstract double monthlyExp();

    }
}
