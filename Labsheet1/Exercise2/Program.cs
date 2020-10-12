/*##########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 05/10/2020
 Link to GitHub for Lab1: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet1
 Description: 1) Revision of Switch statements
              2) Calculates user's points based on the inputed type of grade
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
            string userGrade;
            int userPoints;

            // Getting Data from Users
            Console.Write("Enter type of grade :  ");
            userGrade = Console.ReadLine().ToUpper();

            // Calculating Points
            switch(userGrade)
            {
                case "H1":
                    userPoints = 100;
                    break;
                case "H2":
                    userPoints = 88;
                    break;
                case "H3":
                    userPoints = 77;
                    break;
                case "H4":
                    userPoints = 66;
                    break;
                case "H5":
                    userPoints = 56;
                    break;
                case "H6":
                    userPoints = 46;
                    break;
                case "H7":
                    userPoints = 37;
                    break;
                default:
                    userPoints = 0;
                    break;
            }// end of switch block

            Console.WriteLine($"\nPoints awarded : {userPoints}");


        }// End Main
    }// End Class
}// End Namespace
 
