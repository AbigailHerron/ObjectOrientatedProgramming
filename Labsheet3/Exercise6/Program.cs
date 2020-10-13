/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Displays the average score rating for three different movies
               - Main focus is 2D Arrays
 Parameters: MovieTitle, AverageScore, Scores
 #################################################################################################*/
using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            string[] movieTitles = new string[3] {"Avengers Endgame", "Spider-Man: Far From Home", "Once Upon A Time in Hollywood"};
            int[] averageScores = new int[3];
            int[,] scores = new int[3, 3]
                                {
                                    {3,4,5}, // [0,x]
                                    {1,2,1},// [1,x]
                                    {5,4,2}// [2,x]
                                };
            int score = 0;

            // Calculating averages
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    score += scores[i, j];
                }
                averageScores[i] = score / 3;
                score = 0;
            }// end nested for loop

            // Printing results to screen
            for(int i = 0; i < movieTitles.Length; i++)
            {
                Console.WriteLine("The average score for '{0}' is {1:f}", movieTitles[i], averageScores[i]);
            }// end for block

        }// end Main()
    }// end Class
}// end Namespace
