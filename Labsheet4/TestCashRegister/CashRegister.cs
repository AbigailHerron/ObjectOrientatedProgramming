/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20

 Description: Basic cash register layout
 Properties: Total, NumberOfItems, AllItems, AllTally
 Methods: AddItem()
 #############################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCashRegister
{
    class CashRegister
    {
        /* Declaring Properties ----------------------------------------------*/
        // Read Only
        public double Total { get; private set; }
        public int NumberOfItems { get; private set; }





        /* Declaring Methods -------------------------------------------------*/

        /*---------
        Method: AddItem()
            1) Takes in a double value as the price of an item
            2) Adds the price to the Total property
            3) Increments the NumberOfItems property
        ---------*/
        public void AddItem(double price)
        {
            Total += price;
            NumberOfItems++;
        }// end AddItem()


    }// end CashRegister
}// end TestCashRegister
