/*#########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 05/10/2020
 Link to GitHub for Lab1: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet1
 Description: 1) Revision of If statements
              2) Calculates user's grade based on their grade percentage
 Parameters: User grade
 #########################################################################################################*/
using System;

namespace Labsheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            int userGrade = 0, userPoints = 0;

            // Getting Data from Users
            Console.Write("Enter percentage grade :  ");
            userGrade = int.Parse(Console.ReadLine());

            // Calculating Points
                // Checking percentage from high to low
            if(userGrade >= 90)
            {
                userPoints = 100;
            }
            else if(userGrade >= 80)
            {
                userPoints = 88;
            }
            else if(userGrade >= 70)
            {
                userPoints = 77;
            }
            else if (userGrade >= 60)
            {
                userPoints = 66;
            }
            else if (userGrade >= 50)
            {
                userPoints = 56;
            }
            else if (userGrade >= 40)
            {
                userPoints = 46;
            }
            else if (userGrade >= 30)
            {
                userPoints = 37;
            }
            else
            {
                userPoints = 0;
            }// end of if block (points calculation)


            // Printing Results to Screen
            Console.WriteLine($"\nPoints awarded :  {userPoints}");

        }// End Main
    }// End Class
}// End Namespace