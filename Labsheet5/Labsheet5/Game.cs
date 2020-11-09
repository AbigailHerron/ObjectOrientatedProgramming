/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 09/11/20

 Properties: Name, Price, ReleaseDate
 Methods: ToString() (override), UpdatePrice()
 Constructors: Default, All, Name + Price
 ########################################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet5
{
    class Game
    {
        /*PROPERTIES-------------------------------------------------------------------------------------*/
        public readonly string name;
        public string Name
        {
            get { return name; }
        }
        protected decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }





        /*METHODS----------------------------------------------------------------------------------------*/
        /*Method: ToString()
                  1) Overrides the original ToString() method
                  2) Reterns a formated string value of all Game object properties */
        public override string ToString()
        {
            return String.Format($"Name: {Name}, Price: {Price}, Release Date: {ReleaseDate}");
        }// end ToString()



        /*Method: UpdatePrice()
                  1) Takes in a decimal value (preferably one that represents a percentage)
                  2) Amends the Price of the object by the input decimal value */
        public virtual void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
        }// end UpdatePrice()






        /*CONSTRUCTORS-----------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Assigns default values for Name and Price
                       2) Chains these values into the Name + Price constructor*/
        public Game(): this("", 0)
        {
        }// end Default



        /*Constructor: Name + Price
                       1) Assigns values for Name and Price of initialised Game object
                       2) Chains these values into the All constructor*/
        public Game(string name, decimal price): this(name, price, DateTime.Now)
        {
        }// end Name + Price



        /*Constructor: All
                       1) Assigns values for Name, Price and ReleaseDate */
        public Game(string nameNew, decimal price, DateTime release)
        {
            name = nameNew;
            Price = price;
            ReleaseDate = release;
        }// end All

    }// end Game Class
}// end Namespace
