/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20

 Description: Basic cash register layout
 Properties: Tally, NumberOfItems
 Methods: AddItem(), ToString() (replaces normal ToString())
 #############################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCashRegister
{
    class CashRegister
    {
        /* Declaring Properties ----------------------------------------------*/

        //Read Only
        private double total { get; }
        
            
        // Editable
        public double Tally { get; set; }
        public int NumberOfItems { get; set; }

    }// end CashRegister
}// end TestCashRegister
