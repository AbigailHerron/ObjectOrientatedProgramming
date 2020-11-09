/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 09/11/20

 Description:
 Parameters:
 ########################################################################################################*/
using System;

namespace Labsheet5
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g1 = new Game("Monopoly", 19.99m);
            Game g2 = new Game() { ReleaseDate = new DateTime(2000, 6, 15) };

            Game g3 = new Game("Clue", 15.50m);
            Game g4 = new Game();

            DateTime date1 = new DateTime(1995,13,09);
            //ComputerGame cg1 = new ComputerGame("Crash Bandicoot", 25.99m, new DateTime(1996, 9, 9), "12");
            //ComputerGame cg2 = new ComputerGame("Space Invaders", 5.99m, new DateTime(1978, 3, 10), "3");


            DisplayGame(g3);
            DisplayGame(g4);
            //DisplayGame(cg1);
           // DisplayGame(cg2);

        }// end Main()


        /*METHODS----------------------------------------------------------------------------------------*/
        /*Method: DisplayGame()
                  1) Takes in a Game object
                  2) Prints the properties of the object to the screen */
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }// end DisplayGame()


    }// end Class
}// end Namespace
