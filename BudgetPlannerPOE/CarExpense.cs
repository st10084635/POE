using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerPOE
{
    class CarExpense
    {
        //declaring variables
        private String CarMakeModel;
        private double vehiclePrice;
        private double vehicleDeposit;
        private double vehicleInterestRate;
        private double Insurance;
        
        //costructor
        public CarExpense(string CarMakeModel, double vehiclePrice, double vehicleDeposit, double vehicleInterestRate, double Insurance)
        {
            this.CarMakeModel = CarMakeModel;
            this.vehiclePrice = vehiclePrice;
            this.vehicleDeposit = vehicleDeposit;
            this.vehicleInterestRate = vehicleInterestRate;
            this.Insurance = Insurance;
        }


        public double CarMonthlyCosts()
        {
            double aValue = 0;
            double vehicleMonthlyCost;

            aValue = (vehiclePrice - vehicleDeposit) * (1 + (vehicleInterestRate / 100) * 5);// calculation for the vehicle using A=P(1+i*n)

            vehicleMonthlyCost = aValue / 60;//working out the monthly cost of the vehicle
            vehicleMonthlyCost += Insurance;//adding the insurance premium to the monthly cost

            return vehicleMonthlyCost; //return the monthly cost of the vehicle

        }


    }
}
