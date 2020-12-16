/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20 - 16/12/20
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedProgramming/blob/main/Assessment2/Assessment2/Employee.cs

 Description: 1) A blueprint for an Employee object
              2) Is intended to be an abstract base class
 Properties: FirstName, LastName
 Methods: CalculateMonthlyPay
 Constructors: None
 ##########################################################################################################################*/
using System;

namespace Assessment2
{
    abstract class Employee : IComparable
    {
        /*PROPERTIES -----------------------------------------------------------------------------------*/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string EmpType { get; set; }


        /*METHODS --------------------------------------------------------------------------------------*/
        /*Method: CalculateMonthlyPay()
                  1) Is intended to be modified by potential derived classes */
        public abstract decimal CalculateMonthlyPay(); // end CalculateMonthlyPay()


        /*Method: CompareTo() (override)
                  1) Takes in an Employee object
                  2) Compares this Eployee object to a temporary one */
        public int CompareTo(object obj)
        {
            Employee thisEmp = obj as Employee;
            if (thisEmp == null)
            {
                throw new ArgumentException("This is not an Employee");
            }
            return this.LastName.CompareTo(thisEmp.LastName);
        }// end CompareTo()

    }// end Employee Class
}// end Namepsace
