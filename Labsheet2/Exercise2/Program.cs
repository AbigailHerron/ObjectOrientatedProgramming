/*#################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description: Reading student grades from text file and appending total points to end of file
              - Revision of foreach loop

 Paramenters: Grades, Points
 #################################################################################################################################*/
using System;
using System.IO;

namespace Labsheet2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            string[] grades = File.ReadAllLines(@"C:\temp\Grades.txt");
            int totalPoints = 0, points = 0, grade = 0;

            // Converting grades to points and finding the total
            foreach(string line in grades)
            {
                grade = int.Parse(grades[i]);

                if (grade > 90)
                {
                    points = 100;
                }
                else if (grade > 80)
                {
                    points = 88;
                }
                else if (grade > 70)
                {
                    points = 77;
                }
                else if (grade > 60)
                {
                    points = 66;
                }
                else if (grade > 50)
                {
                    points = 56;
                }
                else if (grade > 40)
                {
                    points = 46;
                }
                else if (grade > 30)
                {
                    points = 37;
                }
                else
                {
                    points = 0;
                }// end if block

                totalPoints += points;
            }// end foreach block

            // Appending totalPoints to the end of Grades.txt
            File.AppendAllText(@"C:\temp\Grades.txt", Environment.NewLine + "Total Leaving Cert Points:  " + totalPoints.ToString());

            // Appending totalPoints to the end of Grades.txt


        }// end Main()
    }// end Program
}// end Namespace
