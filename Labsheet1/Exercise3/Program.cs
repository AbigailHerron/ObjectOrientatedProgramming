/*#########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Link to GitHub for Lab1: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet1

 Description: 1) Revision of nested If statements
              2) Calculates user's grade based on their grade percentage, and subject difficulty
 Parameters: User grade, Subject difficulty
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
            string userDifficulty;

            // Getting Data from Users
            Console.WriteLine("Enter level of subject (Higher or Ordinary) :  ");
            userDifficulty = Console.ReadLine().Trim().ToLower();

            Console.Write("\nEnter percentage grade :  ");
            userGrade = int.Parse(Console.ReadLine());

            // Calculating Points
            // Checking whether subject was higher or ordinary level,
            // then calculating points accordingly
            if (userDifficulty.Substring(0, 1) == "h") // higher level first
            {
                if (userGrade >= 90)
                {
                    userPoints = 100;
                }
                else if (userGrade >= 80)
                {
                    userPoints = 88;
                }
                else if (userGrade >= 70)
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
                }
            }// end of higher level points

            else // start of ordinary level points
            {
                if (userGrade >= 90)
                {
                    userPoints = 56;
                }
                else if (userGrade >= 80)
                {
                    userPoints = 46;
                }
                else if (userGrade >= 70)
                {
                    userPoints = 37;
                }
                else if (userGrade >= 60)
                {
                    userPoints = 28;
                }
                else if (userGrade >= 50)
                {
                    userPoints = 20;
                }
                else if (userGrade >= 40)
                {
                    userPoints = 12;
                }
                else
                {
                    userPoints = 0;
                }
            }// end of if block (points calculation)


            // Printing Results to Screen
            Console.WriteLine($"\nPoints awarded :  {userPoints}");

        }// End Main
    }// End Class
}// End Namespace
