/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20

 Description: 1) A blueprint for a FullTimeEmployee object
              2) Is derived from the abstract Employee class
 Added Properties: Salary
 Altered Methods: CalculateMonthlyPay, ToString
 Constructors: Default, FirstName, FirstName and LastName, All
 #######################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class FullTimeEmployee : Employee
    {
        /*PROPERTIES -----------------------------------------------------------------------------------*/
        public decimal Salary { get; set; }


        /*METHODS --------------------------------------------------------------------------------------*/
        /*Method: CalculateMonthlyPay()
                  1) Overrides base class method
                  2) Calculates the monthly pay by dividing the Salary property by 12 
                  3) Returns the monthly pay */
        public override decimal CalculateMonthlyPay()
        {
            decimal monthlyPay = 0;
            monthlyPay = this.Salary / 12;
            return monthlyPay;
        }// end CalculateMonthlyPay()

        /*Method: ToString() (override) 
                  1) Overrides original ToString() method
                  2) Returns a string value format of LastName (in uppercase), FirstName and type of
                     employee */
        public override string ToString()
        {
            return string.Format($"{this.FirstName.ToUpper()}, {this.LastName} - Full Time");
        }// end ToString()


        /*CONSTRUCTORS ---------------------------------------------------------------------------------*/
        #region Constructor Chain
        /*Constructor: Default
                       1) Declares an object with a default FirstName, LastName and Salary
                       2) Chains these values to the All constructor */
        public FullTimeEmployee() : this("John", "Doe", 0)
        {
        }// end Default constructor


        /*Constructor: FirstName
                       1) Takes a string input as a FirstName property
                       2) Chains this value, with additional default values, to the All constructor */
        public FullTimeEmployee(string firstName) : this (firstName, "", 0)
        {
        }// end FirstName constructor


        /*Constructor: FirstName and LastName
                       1) Takes in two string values for the FirstName and LastName properties 
                          respectively 
                       2) Chains these values, with a default Salary value, to the All constructor */
        public FullTimeEmployee(string firstName, string lastName) : this (firstName, lastName, 0)
        {
        }// end FirstName and LastName constructor

        #endregion
        /*Constructor: All
                       1) Takes in two string values for FirstName and LastName properties 
                       2) Takes in a decimal value for the Salary property 
                       3) Initialises a FullTimeEmployee object with the above values */
        public FullTimeEmployee(string firstName, string lastName, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }// end All constructor

    }// end FullTimeEmployee class
}// end Namespace
