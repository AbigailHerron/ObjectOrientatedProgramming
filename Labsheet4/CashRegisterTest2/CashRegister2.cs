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

namespace Exercise5
{
    class CashRegister2
    {
        /* Declaring Properties ----------------------------------------------*/
        // Read and Write
        public static double allTally { get; set; }
        public static int allItems { get; set; }

        // Read Only
        public double Total { get; private set; }
        public int NumberOfItems { get; private set; }





        /* Declaring Methods -------------------------------------------------*/

        /*---------
        Method: AddItem()
            1) Takes in a double value as the price of an item
            2) Adds the price to the Total property
            3) Increments the NumberOfItems property
            4) Updates the tally for all items sold (allTally) and total number of items sold (allItems)
        ---------*/
        public void AddItem(double price)
        {
            Total += price;
            NumberOfItems++;
            allItems++;
            allTally += price;
        }// end AddItem()


    }// end CashRegister
}// end TestCashRegister
