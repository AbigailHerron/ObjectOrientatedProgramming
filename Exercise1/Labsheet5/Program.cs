/*#######################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 02/11/20

 Description: Testing out the Team Class by making a few Team objects
 Parameters: 
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

        }// end Main()


        // Q6 - Create DisplayTeams method
        /*METHOD - DisplayTeams()
                   1) */
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
