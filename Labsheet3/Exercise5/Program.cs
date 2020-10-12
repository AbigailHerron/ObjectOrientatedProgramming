/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Determines whether there is enough stock in a warehouse to complete a sale
 Parameters: StockOnHand, SaleAmount
 #################################################################################################*/
using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int stockOnHand = 0, saleAmount = 0;

            // Getting sale details from user
            Console.Write("Enter the number of products in store:  ");
            stockOnHand = int.Parse(Console.ReadLine());

            Console.Write("Enter the number required for sale:  ");
            saleAmount = int.Parse(Console.ReadLine());

            // Printing transaction result to screen
            if (MakeTransaction(stockOnHand, saleAmount))
                Console.WriteLine("Let's make a deal!");
            else
                Console.WriteLine("We can't supply this sale");

            

        }// end Main()


        /*---------
        Method: MakeTransaction()
                1) Takes in the number of stock on hand and the ammount required for sale (int values)
                2) Determines whether there is enough stock in the store
                3) Returns true if there is enough to make the sale, or false if there is not
        ---------*/
        static private bool MakeTransaction(int num1, int num2)
        {
            bool possible = false;

            if (num1 >= num2)
                possible = true;

            return possible;
        }// end MakeTransaction()


    }// end Class
}// end Namespace
