/*#########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 05/10/2020
 Link to GitHub for Lab1: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet1

 Description: 1) Revision of Sentinel Controlled While loops
              2) Calculates user's points based on their grade percentage and subject difficulty
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
            string subjectDifficulty = "?"; // must have a value to be used as a condition
            bool higher = false;
            int userGrade = 0, totalPoints = 0, count = 1;


            const string QUIT = "-1";

            // Getting input from User
            while (subjectDifficulty != QUIT)
            {
                // getting user difficulty
                Console.WriteLine("\nEnter '-1' to finish");
                Console.WriteLine("Enter difficulty of subject (high or ord) :  ");
                subjectDifficulty = Console.ReadLine().Trim().ToLower();


                if (subjectDifficulty != QUIT) // just to make the program instantly quit if the sentinel is entered
                {
                    // testing whether higher or ordinary dificulty
                    higher = (subjectDifficulty.Substring(0, 1) == "h") ? true : false;


                    // getting user grade
                    Console.WriteLine($"Enter grade for subject {count} :  ");
                    userGrade = int.Parse(Console.ReadLine());
                    count++; // incrementing the subject number






                    // Calculating total points
                    if (userGrade >= 90)
                    {
                        totalPoints = (higher) ? (totalPoints += 100) : (totalPoints += 56);
                    }
                    else if (userGrade >= 80)
                    {
                        totalPoints = (higher) ? (totalPoints += 88) : (totalPoints += 46);
                    }
                    else if (userGrade >= 70)
                    {
                        totalPoints = (higher) ? (totalPoints += 77) : (totalPoints += 37);
                    }
                    else if (userGrade >= 60)
                    {
                        totalPoints = (higher) ? (totalPoints += 66) : (totalPoints += 28);
                    }
                    else if (userGrade >= 50)
                    {
                        totalPoints = (higher) ? (totalPoints += 56) : (totalPoints += 20);
                    }
                    else if (userGrade >= 40)
                    {
                        totalPoints = (higher) ? (totalPoints += 46) : (totalPoints += 12);
                    }
                    else if (userGrade >= 30)
                    {
                        totalPoints = (higher) ? (totalPoints += 37) : (totalPoints += 0);
                    }
                    else
                    {
                        totalPoints += 0;
                    } // end of if block
                }
            }// end of sentinle while loop


            // Printing Points to Screen
            Console.WriteLine($"\nYour total score is {totalPoints}");



        }// End Main
    }// End Class
}// End Namespace
