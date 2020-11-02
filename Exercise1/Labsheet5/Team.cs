/*#######################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 02/11/20

 Description: A blueprint for a Team object
 Properties: TeamName, Games, Wins, Draws, Losses, Points
 Constructors: 1) Default (Team();)
               2) With TeamName (Team(Name Of Team);)
 #######################################################################################*/
 using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet5
{
    // Q8 - Create an enum called Result
    // More information on enum can be found here: https://www.tutorialsteacher.com/csharp/csharp-enum
    enum Result
    {
        Win,
        Draw,
        Lose
    }// end Result

    class Team
    {
        /*PROPERTIES ------------------------------------------------------------------------------------ */
            // Q1 - Create properties with private setters
        public string TeamName { get; private set; }
        public int Games { get; private set; }
        public int Wins { get; private set; }
        public int Draws { get; private set; }
        public int Losses { get; private set; }


        // Q2 - Declaring points property (calculation needed)
        private int points = 0;
        public int Points
        {
            get
            {
                points = (this.Wins * 3) + (this.Draws);
                return points;
            }
        }// end Points property








        /*METHODS --------------------------------------------------------------------------------------- */
        // Q5 - Create DisplayTeamTable method
        /*METHOD - DisplayTeamTable()
                   1) Displays the Team objects in a table format */
        public string DisplayTeamTable()
        {
            return string.Format($"{TeamName, -15}{Points, -7}{Wins, -7}{Draws, -7}{Losses, -7}{Games, -7}");
        }// end DisplayTeamTable()


        // Q9 - Create AddResult method
        /*METHOD - AddResult()
                   1) Increments the number of games played (Games property)
                   2) Increments the Wins, Draws or Losses properties based on the 
                      result passed */
        public void AddResult(Result result)
        {
            Games++;

            switch(result)
            {
                case Result.Win:
                    Wins++;
                    break;
                case Result.Draw:
                    Draws++;
                    break;
                case Result.Lose:
                    Losses++;
                    break;
            }
        }// end AddResult()





        /*CONSTRUCTORS ---------------------------------------------------------------------------------- */
        /*Constructor 1: Default
                         1) Sets TeamName to Unknown */
        public Team()
        {
            TeamName = "Unknown";
        }// end Constructor 1 (Default Constructor)

        // Q3a - Declare Constructor with TeamName
        /*Constructor 2: Team Name Entered
                         1) Sets TeamName to what was passed */


        public Team(string name)
        {
            TeamName = name;
        }// end Constructor 2 (TeamName Constructor)



    }// end Team
}// end Namespace
