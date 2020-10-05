/*##########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
  Link to GitHub for Lab1: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet1

 Description: 1) Revision of Switch statements
              2) Calculates user's points based on the inputted percentage grade
 Parameters: User grade
 ##########################################################################################################*/
using System;

namespace Labsheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            int userGrade = 0, userPoints = 0;
            int[] gradeBrackets = new int[] {90, 80, 70, 60, 50, 40};

            // Getting Data from Users
            Console.Write("Enter percentage grade :  ");
            userGrade = int.Parse(Console.ReadLine());

            // Calculating Points
            switch(userGrade)
            {
                

            }


        }// End Main
    }// End Class
}// End Namespace
