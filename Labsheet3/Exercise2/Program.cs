/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Returns the cost of a product based on the entered description
 Parameters: Item
 #################################################################################################*/
using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            string item = "?";
            double cost = 0;


            // Getting input from user
            Console.Write("Enter product type:  ");
            item = Console.ReadLine().ToLower();

            // Calculating cost of item
            switch(item)
            {
                case "jeans":
                    cost = 67.99;
                    break;
                case "jacket":
                    cost = 68.99;
                    break;
                    break;
                case "boots":
                    cost = 34.99;
                    break;
                case "scarves":
                case "belts":
                case "socks":
                    cost = 10.00;
                    break;
                default:
                    cost = -999;
                break;
            }// end switch block

            // Printing results to screen
            Console.WriteLine("The cost of this item is {0:f}", cost);

        }// end Main()
    }// end Class
}// end Namespace
