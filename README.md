Budget Planner app
****************************************************************
Creator- Kael du Plooy st10084635

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
This is version 2 of this application
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Software requirements:

Visual studio 2019 was used to create this application

Made use of .NET Framework 4.7.2

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Installation instructions

1. Unzip the folder
2. Move the folder to your repos under users
3. Download link for .NET Framework 4.7.2.: https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Useage:

1. Open the folder where the application is located.
2. From there you can either open the .sln folder for Visual studio that will display the code or you can open the bin folder and then click the debug folder after
 that where you will find BudgetPlannerPOE, if this is opened it will run the application itself without the need to open visual studio.

3. If you chose to open the .sln folder for visual studio you will need to click the run button some where near the top of visual studio
4. Once you click the run button you will open the application(This is also from where you will have to follow if you chose the latter option at the 2nd bullet point).
It will display the name of the application to the user.

5. After that the application will ask the user a set requests. The first one will be to please enter the users monthly income and then followed by what the user 
thinks his tax will be for the month.

6. After that the application will request the user to insert the following expenses, they are: Groceries, water and lights, Telephone, Other and Travel Costs.
PS. its not necesarily in that order.

7. after the user inserted the list of expenditures he will be asked if he wants to buy a property or rent one. This will be handled by an if else statement.
If the user whishes to rent a property they will need to insert the value 1 and press enter, if they wish to buy a property they should press any other key
on the keyboard and then press enter.

8.1. If the user wanted to rent a property they will be prompted to enter the monthly rental amount by the application.

8.5. If the user chose to buy a property he will be presented with another set of questions. They are as follow: 
Please enter the purchase price of the property, Please enter the deposit of the property, Please enter the Interest rate of the property in percentage,
Please enter the number of months to pay for the property.
The application will then do a calc that will work out the monthly cost that the user needs to pay every month.
At the same time if the monthly cost exceeds a 3rd of the users monthly income it will display an alert that states that the bank will most likely not allow
the loan to happen.

9. After this the user will be prompted if he wants to buy a vehicle. This will also be handled by an if else statement. If the user wishes to buy a vehicle
they will have to insert 1 and press enter. If they wish to not buy a vehicle they should insert any other key and then press enter.

10.1. If the user pressedone he will yet again be prompted with a set questions which are:
Please insert the purchase price of the vehicle, Please insert the deposit of the vehicle, Please insert the Intrest of the vehicle and Please enter the 
Insurance premium for the vehicle.
The application will then calc the monthly cost of the vehicle using the formalu A=P(1+i*n) and then add the insurance premium to the monthly cost.

10.5. If the user chose to not buy a vehicle the application will set the vehicle expense to 0.

11. After this the application will check if the users total expenditures for the month does not exceed 75% of his monthly income, if it does however 
exceed that amount a warning message will pop up.

12. If the warning subsides or doesnt pop up at all the user all the expenses will be displayed next in descending order.

13. Then after that the application will calculate and display the money the user has left after all the expenses were deducted from his monthly income.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Changes made:

1. Fixed the calc bug with the home loan.
2. Added more comments to the overall prohject.
3. Change my array where all the varaibles were stored to a list T.
4. Implemented an abstract class in the over project which included abstract methods.
5. Improved the over all house keeping of the project.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
FAQ's

1. 
Q: What is the current bank interest rate for a home loan?
A: The current average bank interest rate is 10%.

2. 
Q: What is the average cost of Insurance for a car to the value of R200000?
A: The average cost for a driver over the age of 25years is R750 per month.

3.
Q: What is the maximum term for a home loan?
A: The maximum term is 360 months.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Dev Contact info--->

Cell: 068 200 9239
Email: st10084635@vcconnect.edu.za/kaelduplooy@gmail.com
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

References: 
Tinyurl.com. 2022. 9.4 Calculations using simple and compound interest | Finance and growth | Siyavula. [online] Available at: <https://tinyurl.com/mumwwahs> [Accessed 3 June 2022].


