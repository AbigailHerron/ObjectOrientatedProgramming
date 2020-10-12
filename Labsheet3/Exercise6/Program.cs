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
            string[] moveTitles = new string[3] {"Avengers Endgame", "Spider-Man: Far From Home", "Once Upon A Time in Hollywood"};
            int[] averageScores = new int[3];
            int[,] scores = new int[3, 3]
                                {
                                    {3,1,5}, // [0,x]
                                    {4,2,4},// [1,x]
                                    {5,1,2}// [2,x]
                                };
            int score = 0;

            // Calculating averages
            for(int i = 0; i < moveTitles.Length; i++)
            {
                for(int j = 0; j < averageScores.Length; j++)
                {
                    score += scores[i, j];
                }
                averageScores[i] = score / 3;
                score = 0;
            }// end nested for loop

            // Printing results to screen
            for(int i = 0; i < moveTitles.Length; i++)
            {
                Console.WriteLine($"The average score for '{moveTitles[i]}' is {averageScores[i]}");
            }// end for block

        }// end Main()
    }// end Class
}// end Namespace
