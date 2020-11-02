/*#######################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 02/11/20
 Link to GitHub: 

 Description: Testing out the Team Class by making a few Team objects
 Parameters: Team objects
 #######################################################################################*/
using System;
using System.Collections.Generic;

namespace Labsheet5
{
    


    class Program
    {
        static void Main(string[] args)
        {

            // Q3b - Delcaring Team Objects with Constructor
            Team SligoRovers = new Team("Sligo Rovers");
            Team FinnHarps = new Team("Finn Harps");
            Team GalwayUnited = new Team("Galway United");
            Team DerryCity = new Team("Derry City");
            Team Dundalk = new Team("Dundalk");

            // Q4 - Create List with these objects
            List < Team > teams = new List<Team>();
            teams.Add(SligoRovers);
            teams.Add(FinnHarps);
            teams.Add(GalwayUnited);
            teams.Add(DerryCity);
            teams.Add(Dundalk);

            // Q7 - Use DisplayTeams() to display the league
            DisplayTeams(teams);

            // Q10 - Update the league results using using AddResult()
            // Note: the enum Reults is stored in the Team.cs file, before Team Class
            //       (so in the Labsheet5 Namespace)
            SligoRovers.AddResult(Result.Win);
            FinnHarps.AddResult(Result.Lose);
            FinnHarps.AddResult(Result.Draw);
            GalwayUnited.AddResult(Result.Win);
            Dundalk.AddResult(Result.Lose);


            // Q11 - Display the new results
            Console.WriteLine();// For neatness
            DisplayTeams(teams);

            // Q13 - Sort and then Reverse the teams List
            teams.Sort();
            teams.Reverse();
            Console.WriteLine();// For neatness
            DisplayTeams(teams);// Testing answer

        }// end Main()




        // Q6 - Create DisplayTeams method
        /*METHOD - DisplayTeams()
                   1) Prints the heading of the League Table to the screen
                   2) Loops through a list of Team objects and displays their properties
                      in a tabled format, using the Team classes 'DisplayTeamTable()'
                      method */
        static void DisplayTeams(List<Team> teams)
        {
            Console.WriteLine("{0, -15}{1, -7}{2, -7}{3, -7}{4, -7}{5, -7}", "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

            foreach(Team team in teams)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }
        }// end DisplayTeams()

    }// end Class
}// end Namespace
