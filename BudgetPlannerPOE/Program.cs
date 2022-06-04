using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlannerPOE
{
    //creating delegate of usernotification
    public delegate void UserNotificationDelegate(double totalExp, double HousingCost, double CarExp, double mi);

    class Program
    {
        //declaring variables used in app
        private static double MonthlyIncome;
        private static double TaxDeducted;
        private static double totalExpense;
        private static double housing;
        private static double FinalIncome;

        //declaring variables used to initiate task 2
        private static string carChoice;
        private static double CarTotalExpense;

        //declaring task 2 variables
        private static string CarMakeModel;
        private static double vehiclePrice;
        private static double vehicleDeposit;
        private static double vehicleInterestRate;
        private static double Insurance;

        //creating an expense list
        private static List<double> expenses = new List<double>();


        static void Main(string[] args)
        {
            //instantiating delegate for the user notification
            UserNotificationDelegate und = new UserNotificationDelegate(UserNotification);

            //creating an object of the homeloan class
            HomeLoan hl = new HomeLoan();


            //string to ask the user if he wants to rent or buy an accomodation
            string AccomodationOption;

            //housekeeping
            Console.WriteLine("Welcome to the student budget planner" +
                "\n====================================================================");

            //requesting input from user
            Console.WriteLine("Please enter your Gross Monthly Income before deductions: ");
            MonthlyIncome = double.Parse(Console.ReadLine());//requesting input from the user

            Console.WriteLine();

            //requesting input from user
            Console.WriteLine("Please enter your estimated tax deduction: ");
            TaxDeducted = double.Parse(Console.ReadLine());

            

            Console.WriteLine();
            //requesting input from user
            Console.WriteLine("Please enter the following monthly expenditures--->");
            Console.Write("Groceries: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));//Adding the value that was inputted by the user to the list

            //requesting input from user
            Console.Write("Water and Lights: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));//Adding the value that was inputted by the user to the list

            //requesting input from user
            Console.Write("Travel costs: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));//Adding the value that was inputted by the user to the list

            //requesting input from user
            Console.Write("Cell phone and telephone costs: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));//Adding the value that was inputted by the user to the list

            //requesting input from user
            Console.Write("Other expenses: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));//Adding the value that was inputted by the user to the list

            Console.WriteLine("====================================================================");
            
            Console.WriteLine();
            

            //requesting if the user wants to rent an accomodation or buy one
            Console.WriteLine("Would you like to rent an accomodation or buy one? " +
                "\nIf you would like to Rent an accomodation please press 1, otherwise if you would like " +
                "to buy an accomodation please press any other key.");
            AccomodationOption = Console.ReadLine();//input from the user deciding whether he wants to buy a property or rent one

            Console.WriteLine("\n====================================================================");

            //if else satement to display depending on the users option
            if (AccomodationOption.Equals("1"))
            {
                rentalAmount();// calling a method that will run if rent was chosen
            }
            else
            {
                loanAmount();// calling a method that will run if buying a property was chosen

                hl.ApprovalCheck(MonthlyIncome);// to check if the homeloan will be approved

            }

            Console.WriteLine("\n====================================================================");

            //requesting input from user to see if he wantsto buy a vehicle
            Console.WriteLine("\nWould you like to buy a vehicle. If you do please press 1," +
                " if you do not wish to purchase a vehicle please press any other key.");
            carChoice = Console.ReadLine();//input from the user that is the deciding factor

            Console.WriteLine("\n====================================================================");

            //if else statement that displays a method or sets a value to 0 depending on the users choice
            if (carChoice == "1")
            {
                CarInput();//calling method where the user will insert the values

                CarExpense ce = new CarExpense( CarMakeModel,  vehiclePrice,  vehicleDeposit,  vehicleInterestRate,  Insurance);//object of a class CarExpense

                CarTotalExpense = ce.CarMonthlyCosts();//this is the calc for car monthly costs
            }
            else
            {
                CarTotalExpense = 0;//setting value to 0 if the user doesnt want to buy a car.
            }

            //to check if the total monthly expenditure is less than 75% of the monthly income
            und(totalExpense, housing, CarTotalExpense, MonthlyIncome);

            //method to dislay the expenses
            displayExpenses();

            //method to display final amount after expenses were deducted
            MoneyAfterDeductions();

            Console.WriteLine();
            Console.WriteLine("End of application.");

            Console.ReadLine();

        }

        //method for rent
        public static void rentalAmount()
        {
            //creating an object of the rental class
            Rental run = new Rental();

            //setting all the expenses 
            run.setExpenses(expenses);

            //storing all the expenses into the variable total expenses
            totalExpense = run.getExpenses();

            //storing the monthly rent into the housing variable if rent was chosen
            housing = run.monthlyExp();


        }

        //method for home loan
        public static void loanAmount()
        {
            //creating an object of the home loan class
            HomeLoan run = new HomeLoan();

            //setting all the expenses
            run.setExpenses(expenses);

            //storing all the expenses into the variable totalExpenses
            totalExpense = run.getExpenses();

            //storing the monthlyloan amount that needs to be paid into housing if buying a property was chosen
            housing = run.monthlyExp();


        }

        //method to display expenses
        static void displayExpenses()
        {
            
            Thread.Sleep(500);
            Console.WriteLine("\n===================================================================================================" +
                "\n\nExpenses listed:\n");

            //foreach loop to display all the expenses in decending order
            int count = 1;
            foreach (double d in expenses.OrderByDescending(d => d))
            {
                Console.WriteLine(count + ": R" + d.ToString("F"));
                count++;
            }

            Console.WriteLine("\nAccomodation cost: R" + housing.ToString("F"));

            if (CarTotalExpense != 0)
            {
                Console.WriteLine("Car cost: R" + CarTotalExpense.ToString("F"));
            }
        }

        //method to calc money after deductions
        public static void MoneyAfterDeductions()
        {
            //rounding down the final value to 2 decimal places
            Math.Round(FinalIncome = MonthlyIncome-TaxDeducted-totalExpense-housing- CarTotalExpense, 2);

            Console.WriteLine("Calulating money after deductions.");

            //thread to slow down the process of the application
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " ");

                Thread.Sleep(1000);
            }

            Console.WriteLine("\n===================================================================================================" +
                "\nThe following will be your available money after deductions: R" + FinalIncome);// displaying the final value

        }

        //method for car input
        public static void CarInput()
        {
            //requesting the value of the from the user for the vehicles
            Console.WriteLine("Please enter the following: " +
                "\n========================================================================");

            //requesting input from user
            Console.Write("Please enter the car make and model: ");
            CarMakeModel = Console.ReadLine();

            //requesting input from user
            Console.Write("Please enter the purchase price of the vehicle: ");
            vehiclePrice = Convert.ToDouble(Console.ReadLine());

            //requesting input from user
            Console.Write("Please enter the deposit that needs to be paid for the vehicle: ");
            vehicleDeposit = Convert.ToDouble(Console.ReadLine());

            //requesting input from user
            Console.Write("Please enter the interest rate in percentage (use this format = 12,5 and not 12.5): ");
            vehicleInterestRate = Convert.ToDouble(Console.ReadLine());

            //requesting input from user
            Console.Write("Please enter the insurance rate for the vehicle: ");
            Insurance = Convert.ToDouble(Console.ReadLine());
        }


        static void UserNotification(double totalExp, double HousingCost, double mi, double CarExp)
        {

            double totalMonthlyExp;

            totalMonthlyExp = totalExp + HousingCost + CarExp;

            //if statement to display a message if the total expenses exceed 75% of your monthly income.
            if (totalMonthlyExp>=(mi*0.75))
            {
                //turning the back ground color from black to red for the error message
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                //if it is display error message
                Console.WriteLine("Warning! Your total Expenses is more than 75% than your monthly income.");

                //reverting color back to black and white
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        



    }

    
}

