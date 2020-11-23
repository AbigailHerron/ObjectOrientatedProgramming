/*##############################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 23/11/20

 Description: 1) Testing out the Song class with a few Song objects in a List
              2) Trying out the IComparable CompareTo() method with the list
 Parameters: None
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
            Song s4 = new Song("IN THIS MOMENT", "IN THE AIR TONIGHT", "4:57", "Rock");
            Song s5 = new Song("MONSTA X", "WHO DO YOU LOVE", "3:19", "Pop");

            List<Song> Playlist = new List<Song> { s1, s2, s3, s4, s5 };

            Console.WriteLine("Regular List");
            Console.WriteLine($"{"Artist", -20}{"Title", -30}{"Duration", -10}{"Genre", -10}");
            foreach(Song song in Playlist)
            {
                Console.WriteLine(song.ToString());
            }
            Console.WriteLine();// new line for neatness



            Playlist.Sort();
            Console.WriteLine("Ordered List");
            Console.WriteLine($"{"Artist",-20}{"Title",-30}{"Duration",-10}{"Genre",-10}");
            foreach (Song song in Playlist)
            {
                Console.WriteLine(song.ToString());
            }
            Console.WriteLine();// new line for neatness

            Shuffle(Playlist);
            Console.WriteLine("Shuffled List");
            Console.WriteLine($"{"Artist",-20}{"Title",-30}{"Duration",-10}{"Genre",-10}");
            foreach (Song song in Playlist)
            {
                Console.WriteLine(song.ToString());
            }
            Console.WriteLine();// new line for neatness

        }// end Main()

        /*METHODS -----------------------------------------------------------*/
        /*Method: Suffle()
                  1) Takes in a list of Song objects
                  2) Re-orders the list based on a random number */
        public static void Shuffle(List<Song> songs)
        {
            Song temp = new Song();
            Random rand = new Random();
            int index;

            for(int i = 0; i < songs.Count; i++)
            {
                index = rand.Next(songs.Count);
                temp = songs[i];
                songs[i] = songs[index];
                songs[index] = temp;
            }
        }// end Shuffle()
    }// end Class
}// end Namespace
