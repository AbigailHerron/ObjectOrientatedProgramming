/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 09/11/20

 Description: Subclass of Game
 Additional Features: 
            Properties: PEGI
            Methods: GetDiscountPrice(), UpdatePrice() (override)
            Constructors: Default, All
 ########################################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet5
{
    class ComputerGame: Game
    {

        /*PROPERTIES-------------------------------------------------------------------------------------*/
        public string PEGI { get; set; }


        /*METHODS----------------------------------------------------------------------------------------*/
        /*Method: GetDiscountPrice()
                  1) Returns a value of 0.9 times the Price value */
        public decimal GetDiscountPrice()
        {
            return Price * 0.9m;
        }// end GetDiscountPrice()



        /*Method: UpdatePrice()
                  1) Takes in a decimal value (preferably one that represents a percentage)
                  2) Amends the Price of the object by the input decimal value */
        public override void UpdatePrice(decimal percentageIncrease)
        {
            base.UpdatePrice(percentageIncrease);
            Console.WriteLine("Updating from ComputerGame class");

        }// end UpdatePrice()


        /*CONSTRUCTORS-----------------------------------------------------------------------------------*/
        /*Constructor: Default
                       1) Calls the base default constructor in Game class */
        public ComputerGame(): base()
        {
        }// end Default





        /*Constructor: All
                       1) Calls the base all constructor in Game class
                       2) Adds value for PEGI property */
        public ComputerGame(string name, decimal price, DateTime release, string pegi) : base(name, price, release)
        {
            PEGI = pegi;
        }// end All

    }// end ComputerGame Class
}// end Namespace
