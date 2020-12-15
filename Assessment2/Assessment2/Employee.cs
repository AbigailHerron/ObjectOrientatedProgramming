/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20

 Description: 1) A blueprint for an Employee object
              2) Is intended to be an abstract base class
 Properties: FirstName, LastName
 Methods: CalculateMonthlyPay
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
        protected string FirstName { get; set; }
        protected string LastName { get; set; }



        /*METHODS --------------------------------------------------------------------------------------*/
        /*Method: CalculateMonthlyPay()
                  1) Is intended to be modified by potential derived classes */
        public abstract decimal CalculateMonthlyPay(); // end CalculateMonthlyPay()

    }// end Employee Class
}// end Namepsace
