/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20

 Description:  1) Creates and displays the details of several CashRegister objects
               2) Making use of the methods defined in CashRegister class to tally
                  up a total for a sale
 Paramenters: Item1, Item2, Item3, Reg1, Reg2
 #############################################################################################*/
using System;

namespace TestCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            double item1 = 54.99;
            double item2 = 25.50;
            double item3 = 62.77;

            // Creating two CashRegister objects
            CashRegister reg1 = new CashRegister();
            CashRegister reg2 = new CashRegister();


            // Adding items to basket for cash_register 1 (reg1)
            Console.WriteLine($"Adding item at {item2} to Cash Register 1");
            reg1.AddItem(item2);
            Console.WriteLine($"Adding item at {item3} to Cash Register 1");
            reg1.AddItem(item3);

            // Adding items to basket for cash_register 2 (reg2)
            Console.WriteLine($"Adding item at {item1} to Cash Register 2");
            reg2.AddItem(item1);
            Console.WriteLine($"Adding item at {item1} to Cash Register 2");
            reg2.AddItem(item1);
            Console.WriteLine($"Adding item at {item3} to Cash Register 2");
            reg2.AddItem(item3);


            // Printing current totals for both cash_register objects to screen
            Console.WriteLine("\nCurrent tally in Cash Register 1 is: {0:f} for {1} items", reg1.Total, reg1.NumberOfItems);
            Console.WriteLine("Current tally in Cash Register 2 is: {0:f} for {1} items", reg2.Total, reg2.NumberOfItems);

        }// end Main()
    }// end Class
}// end TestCashRegister
