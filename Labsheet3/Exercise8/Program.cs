/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Records and displays the name of each player on a team
               - Main focus is Lists
 Parameters: PlayerName
 #################################################################################################*/
using System;
using System.Collections.Generic;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            List<string> teamNames = new List<string>();
            const string QUIT = "-1";
            string userInput = "?";
            int counter = 1;

            // Getting team names from user
            Console.WriteLine("Enter '-1' when all team players have been entered");
            do
            {
                Console.WriteLine($"Enter name of team member {counter}:  ");
                userInput = Console.ReadLine();
                Console.WriteLine(); // new line for neatness

                if (userInput != QUIT)
                    teamNames.Add(userInput);

                counter++;
            } while (userInput != QUIT);


            // Organising teamNames in alphabetical order
            teamNames.Sort();

            // Displaying team names
            Console.WriteLine("Full Team Roster:");
            Console.WriteLine("-------------------------------------");
            foreach(string name in teamNames)
            {
                Console.WriteLine(name);
            }// end foreach block

        }// end Main()
    }// end Class
}// end Namespace
