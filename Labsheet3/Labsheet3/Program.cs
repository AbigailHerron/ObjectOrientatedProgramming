/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Tests whether a user can enter a site or not based on their age
 Parameters: userAge
 #################################################################################################*/
using System;

namespace Labsheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delcaring variables
            int userAge = 0;

            // Getting data from user
            Console.Write("Enter your age:  ");
            userAge = int.Parse(Console.ReadLine());

            if (ValidAge(userAge))
                Console.WriteLine("This is a valid age, you can enter the site");
            else
                Console.WriteLine("This is an invalid age, you can't be here");

        }// end Main()



        /*------------
        Method: ValidAge()
                1) Accepts an int value
                2) Checks whether the int value is in the range 18 to 21 inclusive
                3) Returns true or false
        ------------*/
        static private bool ValidAge(int age)
        {
            bool validAge = false;

            if ((age >= 18) && (age <= 21))
                validAge = true;

            return validAge;
        }// end ValidAge()

    }// end Class
}// end Namespace
