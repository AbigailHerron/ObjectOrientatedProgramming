/*##############################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 23/11/20

 Description:
 Parameters:
 ##############################################################################*/
using System;
using System.Collections.Generic;

namespace PracticeQuestionsWeek9
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declaring variables
            Song s1 = new Song("ED SHEERAN", "I SEE FIRE", "4:54", "Pop");
            Song s2 = new Song("THE SCRIPT", "THE END WHERE I BEGIN", "3:34", "Rock");
            Song s3 = new Song("MONSTA X", "JEALOUSY", "3:34", "Pop");
            Song s4 = new Song("MONSTA X", "WHO DO YOU LOVE", "3:19", "Pop");
            Song s5 = new Song("IN THIS MOMENT", "IN THE AIR TONIGHT", "4:57", "Rock");

            List<Song> Playlist = new List<Song> { s1, s2, s3, s4, s5 };

        }// end Main()
    }// end Class
}// end Namespace
