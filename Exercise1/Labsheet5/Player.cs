/*#######################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 02/11/20

 Description: A blueprint for a Player object
 Properties: PlayerName, Postion
 Methods: ToString() (re-writes original)
 Constructors: 1) Default (Player();)
 #######################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet5
{ // Q14a - Create the Player class
    class Player
    {
        /*PROPERTIES ------------------------------------------------------------------------------------ */
        string PlayerName { get; set; }
        string Position { get; set; }

        /*METHODS --------------------------------------------------------------------------------------- */
        /*METHOD - ToString()
                   1) Overrides the ToString method
                   2) Returns a string in the format of 'PlayerName - Position'*/
        public override string ToString()
        {
            return string.Format($"{PlayerName} - {Position}");
        }// end ToString()

    }// end Player Class

}// end Namespace
