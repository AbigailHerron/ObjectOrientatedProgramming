/*#########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20

 Description: 1) A blueprint for a FullTime employee object
              2) Is a derived class of the Employee class
 Added Properties: none
 Changed Methods: CalculatePay
 Constructors: Default, All
 ########################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class FullTime : Employee
    {
        /*METHODS --------------------------------------------------------------------------------------*/
        /*Method: CalculatePay() (override)
                  1) Overrides base class CalculatePay()
                  2) Takes in a salary (annual ammount) as a decimal and divides it by 12 to get
                     the monthly pay 
                  3) Passes this value back to the original CalculatePay() method in the base class */
        protected override void CalculatePay(decimal ammount)
        {
            decimal monthly = ammount / 12;
            base.CalculatePay(monthly);
        }// end CalculatePay()


    }// end FullTime class
}// end Namespace
