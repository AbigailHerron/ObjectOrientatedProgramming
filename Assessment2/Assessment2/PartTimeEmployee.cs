/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20

 Description: 1) A blueprint for a PartTimeEmployee object
              2) Is derived from the abstract Employee class
 Added Properties: HourlyRate, HoursWorked
 Altered Methods: CalculateMonthlyPay, ToString
 Constructors: Default, FirstName, FirstName and LastName, FirstName LastName and HourlyRate, All
 #######################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class PartTimeEmployee : Employee
    {
        /*PROPERTIES -----------------------------------------------------------------------------------*/
        public decimal HourlyRate { get; set; }
        public double HoursWorked { get; set; }


        /*METHODS --------------------------------------------------------------------------------------*/
        /*Method: CalculateMonthlyPay()
                  1) Overrides base class method
                  2) Calculates the monthly pay by multiplying the HourlyRate by the HoursWorked 
                  3) Returns the monthly pay */
        public override decimal CalculateMonthlyPay()
        {
            decimal monthlyPay = 0;
            monthlyPay = this.HourlyRate * (decimal)this.HoursWorked;
            return monthlyPay;
        }// end CalculateMonthlyPay()


        /*Method: ToString() (override) 
                  1) Overrides original ToString() method
                  2) Returns a string value format of LastName (in uppercase), FirstName and type of
                     employee */
        public override string ToString()
        {
            return string.Format($"{this.FirstName.ToUpper()}, {this.LastName} - Part Time");
        }// end ToString()


        /*CONSTRUCTORS ---------------------------------------------------------------------------------*/
        #region Constructor Chain
        /*Constructor: Default
                       1) Declares an object with a default FirstName, LastName, HourlyRate and
                          HoursWorked properties
                       2) Chains these default values to the All constructor */
        public PartTimeEmployee() : this("Jane", "Doe", 0, 0)
        {
        }// end Default constructor


        /*Constructor: FirstName
                       1) Takes a string input as a FirstName property
                       2) Chains this value, with additional default values, to the All constructor */
        public PartTimeEmployee(string firstName) : this(firstName, "", 0, 0)
        {
        }// end FirstName constructor


        /*Constructor: FirstName and LastName
                       1) Takes in two string values for the FirstName and LastName properties 
                          respectively 
                       2) Chains these values, with a default HourlyRate and HoursWorked values,
                          to the All constructor */
        public PartTimeEmployee(string firstName, string lastName) : this(firstName, lastName, 0, 0)
        {
        }// end FirstName and LastName constructor



        /*Constructor: FirstName, LastName and HourlyRate
                       1) Takes in two string values for the FirstName and LastName properties 
                          respectively
                       2) Takes in a decimal value for the HourlyRate property 
                       3) Chains these values, with a default HoursWorked value, to the All
                          constructor */
        public PartTimeEmployee(string firstName, string lastName, decimal hourlyRate) : this(firstName, lastName, hourlyRate, 0)
        {
        }// end FirstName, LastName and HourlyRate constructor


        #endregion
        /*Constructor: All
                       1) Takes in two string values for FirstName and LastName properties 
                       2) Takes in a decimal value for the Salary property 
                       3) Initialises a FullTimeEmployee object with the above values */
        public PartTimeEmployee(string firstName, string lastName, decimal hourlyRate, double hoursWorked)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
        }// end All constructor

    }// end PartTimeEmployee class
}// end Namespace
