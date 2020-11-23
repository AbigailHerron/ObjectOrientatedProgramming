/*##############################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 23/11/20

 Description: A blueprint for a Song object
 Properties: Title, Artist, Duration, Genre
 Enums: Genre
 Methods: ToString(override)
 Constructors: Default, Title, Title and Artist, Title, Artist and Duration, All
 ##############################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestionsWeek9
{
    // Declaring Enums
    enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }// end Genre enum


    class Song : IComparable<Song>
    {
        /*PROPERTIES ----------------------------------------------------------*/
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }



        /*METHODS -------------------------------------------------------------*/
        /*Method: ToString()
                  1) Overrides original ToString()
                  2) Returns the properties of the song object as a single
                     string */
        public override string ToString()
        {
            return $"{this.Artist,-20}{this.Title,-20}{this.Duration,-10}{this.Genre,-10}";
        }// end ToString()



        /*Method: CompareTo()
                  1) Using IComparable interface
                  2) */
        public int CompareTo(Song other)
        {
            return (this.Artist.CompareTo(other.Artist) + this.Title.CompareTo(other.Title)) / 2;
        }// end CompareTo()

        #region Constructors
        /*CONSTRUCTORS --------------------------------------------------------*/
        /*Constructor: Default
                       1) Creats a blank song object */
        public Song()
        {
        }// end Default constructor



        /*Constructor: Title
                       1) Crates a song object with a populated This property */
        public Song(string title)
        {
            this.Title = title;
        }// end Title constructor



        /*Constructor: Title and Artist
                        1) Links to 'Title' constructor
                        2) Populates the Artist property */
        public Song(string title, string artist) : this(title)
        {
            this.Artist = artist;
        }// end Title and Artist constructor



        /*Constructor: Title, Artist and Duration
                       1) Links to 'Title and Artist' constructor
                       2) Populates the Duration property */
        public Song(string title, string artist, string duration) : this(title, artist)
        {
        this.Duration = duration;
        }// end Title, Artist and Duration constructor



        /*Constructor: All
                      1) Links to the 'Title, Artist and Duration' constructor
                      2) Populates the Genre property */
        public Song(string title, string artist, string duration, string genre) : this(title, artist, duration)
        {
            this.Genre = genre;
        }// end All constructor
        #endregion
    }// end Song Class
}// end Namespace
