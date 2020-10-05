/*#########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Link to GitHub for Lab1: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet1

 Description: 1) Revision of for loops
              2) Calculates user's total points based on their grade percentage, and subject difficulty
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
            string subjectLevel;
            int totalPoints = 0, grade = 0;
            int[] userGrades = new int[7];
            bool higher = false;

            // Getting Input from User
            for(int i = 0; i < 7; i++)
            {
                Console.Write($"\nEnter level of subject {i +1} (high or ord) :  ");
                subjectLevel = Console.ReadLine().Trim().ToLower();

                // checking whether the subject is higher level or ordinary
                if(subjectLevel.Substring(0,1) == "h")
                {
                    higher = true;
                }

                Console.Write($"Enter percentage earned for subject {i + 1} :  ");
                grade = int.Parse(Console.ReadLine());


                // calculating points of grade for subject[i]
                if(grade >= 90)
                {
                    userGrades[i] = (higher) ? 100 : 56;
                }
                else if(grade >= 80)
                {
                    userGrades[i] = (higher) ? 88 : 46;
                }
                else if (grade >= 70)
                {
                    userGrades[i] = (higher) ? 77 : 37;
                }
                else if (grade >= 60)
                {
                    userGrades[i] = (higher) ? 66 : 28;
                }
                else if (grade >= 50)
                {
                    userGrades[i] = (higher) ? 56 : 20;
                }
                else if (grade >= 40)
                {
                    userGrades[i] = (higher) ? 46 : 12;
                }
                else if (grade >= 30)
                {
                    userGrades[i] = (higher) ? 37 : 0;
                }
                else
                {
                    userGrades[i] = 0;
                }// end of if block
            }// end of for loop (getting data)

            // Organising userGrades by value (lowest at 6)
            Array.Sort(userGrades);

            // Calculating total points
            for(int i = 1; i < 7; i++) // start at 1 to avoid lowest grade
            {
                totalPoints = totalPoints + userGrades[i];
            }// end of for loop

            // Printing Results to Screen
            Console.WriteLine($"\nYour total score is : {totalPoints}");




        }// End Main
    }// End Class
}// End Namespace
