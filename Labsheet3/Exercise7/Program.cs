/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Displays the average score rating for three different movies
               - Main focus is 2D Arrays (Jagged Arrays)
 Parameters: MovieTitle, AverageScore, Scores
 #################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            string[] movieTitles = new string[3] { "Avengers Endgame", "Spider-Man: Far From Home", "Once Upon A Time in Hollywood" };
            int[] averageScores = new int[3];
            int[][] scores = new int[][]
                                {
                                new int[] {3,4}, // [0,x]
                                new int[] {1,2,1,3},// [1,x]
                                new int[] {5,4,2}// [2,x]
                                };
            int score = 0;

            // Calculating averages
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    
                    score += scores[i][j]; 
                }
                averageScores[i] = score / scores[i].Length;
                score = 0;
            }// end nested for loop

            // Printing results to screen
            for (int i = 0; i < movieTitles.Length; i++)
            {
                Console.WriteLine("The average score for '{0}' is {1:f}", movieTitles[i], averageScores[i]);
            }// end for block

        }// end Main()
    }// end Class
}// end Namespace