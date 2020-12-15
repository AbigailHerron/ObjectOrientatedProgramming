/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20

 Description: 1) A blueprint for an Employee object
              2) Is intended to be a parent class
 Properties: FirstName, LastName, Pay
 Methods: CalculatePay (virtual), ToString (override)
 Constructors: Default, All
 #######################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Employee
    {
        /*PROPERTIES -----------------------------------------------------------------------------------*/
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected decimal Pay { get; set; }



        /*METHODS --------------------------------------------------------------------------------------*/
        /*Method: CalculatePay()
                  1) Sets the Pay property to the decimal value passed into it
                  2) Is intended to be modified by potential subclasses */
        protected virtual void CalculatePay(decimal wage)
        {
            this.Pay = wage;
        }// end CalculatePay()



        /*Method: ToString()
                  1) Overrides original ToString() method
                  2) Displays LastName (in uppercase), FirstName and object type in
                     that order */
        public override string ToString()
        {
            return string.Format($"{this.LastName.ToUpper()}, {this.FirstName} - {this.GetType()}");
        }// end ToString()



        /*CONSTRUCTORS ---------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Initialises an Employee object with empty properites */
        public Employee()
        {
        }// end Default constructor


        /*Constructor: All
                       1) Initialises an Employee object
                       2) Gives the object a value for the FirstName, LastName
                          and Pay properties */
        public Employee(string firstName, string lastName, decimal pay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Pay = pay;
        }// end All constructor

    }// end Employee Class
}// end Namepsace
