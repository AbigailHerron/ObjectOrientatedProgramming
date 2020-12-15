/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20

 Description: 1) A blueprint for an Employee object
              2) Is intended to be an abstract base class
 Properties: FirstName, LastName
 Methods: CalculateMonthlyPay, ToString (override)
 Constructors: None
 #######################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    abstract class Employee
    {
        /*PROPERTIES -----------------------------------------------------------------------------------*/
        protected abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }



        /*METHODS --------------------------------------------------------------------------------------*/
        /*Method: CalculateMonthlyPay()
                  1) Is intended to be modified by potential derived classes */
        public abstract decimal CalculateMonthlyPay(); // end CalculateMonthlyPay()


        /*Method: ToString()
                  1) Overrides original ToString() method
                  2) Displays LastName (in uppercase), FirstName and object type in
                     that order */
        public override string ToString()
        {
            return string.Format($"{this.LastName.ToUpper()}, {this.FirstName} - {this.GetType()}");
        }// end ToString()

    }// end Employee Class
}// end Namepsace
