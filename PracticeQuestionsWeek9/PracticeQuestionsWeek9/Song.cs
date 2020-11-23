/*##############################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 23/11/20

 Description: A blueprint for a Song object
 Properties: Title, Artist, Duration, Genre
 Enums: Genre
 Methods: ToString(override)
 Constructors: Default, Artist, Artist and Title, Artist Title and Duration, All
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
            return $"{this.Artist,-20}{this.Title,-30}{this.Duration,-10}{this.Genre,-10}";
        }// end ToString()



        /*Method: CompareTo()
                  1) Using IComparable interface
                  2) */
        public int CompareTo(Song other)
        {
            if (this.Artist != other.Artist)
                return this.Artist.CompareTo(other.Artist);
            else
                return this.Title.CompareTo(other.Title);
        }// end CompareTo()

        #region Constructors
        /*CONSTRUCTORS --------------------------------------------------------*/
        /*Constructor: Default
                       1) Creats a blank song object */
        public Song()
        {
        }// end Default constructor



        /*Constructor: Artist
                       1) Crates a song object with a populated This property */
        public Song(string artist)
        {
            this.Artist = artist;
        }// end Artist constructor



        /*Constructor: Artist and Title
                        1) Links to 'Artist' constructor
                        2) Populates the Title property */
        public Song(string artist, string title) : this(artist)
        {
            this.Title = title;
        }// end Artist and Title constructor



        /*Constructor: Artist, Title and Duration
                       1) Links to 'Artist and Title' constructor
                       2) Populates the Duration property */
        public Song(string artist, string title, string duration) : this(artist, title)
        {
        this.Duration = duration;
        }// end Artist, Title and Duration constructor



        /*Constructor: All
                      1) Links to the 'Artist, Title and Duration' constructor
                      2) Populates the Genre property */
        public Song(string artist, string title, string duration, string genre) : this(artist, title, duration)
        {
            this.Genre = genre;
        }// end All constructor
        #endregion
    }// end Song Class
}// end Namespace
