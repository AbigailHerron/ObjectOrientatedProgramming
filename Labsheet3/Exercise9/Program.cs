/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020
 Link to GitHub: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet3

 Description:  Produces a Report based on the sales data  of a number of stores kept in a CSV file
               - Main focus is CSV Files (Comma Seperated Value Files)
 Parameters: PlayerName
 Notes: Displayed below program
 #################################################################################################*/
using System;
using System.IO;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string salesFile = @"C:\temp\sales.txt"; // CSV File with data
            string[] storeId = new string[5]; // See Note b) below
            int[] sales = new int[5];

            string row = "{0, -10}{1, -10}{2, -20}";
            int totalSales = 0, averageSales = 0;

            // Getting data from file
            string[] rows = File.ReadAllLines(salesFile);

            for(int i = 0; i < rows.Length; i++)
            {
                string[] columns = rows[i].Split(',');

                // See Note c) below
                storeId[i] = columns[0];
                sales[i] = int.Parse(columns[1]);
            }// end for block


            // Printing results to screen
            Console.WriteLine(row, "Store ID", "Sales", "Performance");
            for(int i = 0; i < storeId.Length; i++)
            {
                Console.WriteLine(row, storeId[i], sales[i], Performance(sales[i]));
                totalSales += sales[i];
            }// end for block

            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Average Sales: {totalSales/sales.Length}");

        }// end Main()




        /*---------
        Method: Performance()
                1) Takes in the number of sales for the associated store (int value)
                2) Determines whether the value is above a certain range
                3) Returns a string (performance evaluation) based on the range the int value
                   falls into
        ---------*/
        static private string Performance(int sales)
        {
            if(sales > 1999)
            {
                return "Very Good";
            }
            else if(sales > 1000)
            {
                return "Moderate";
            }
            else
            {
                return "Needs Attention";
            }
        }// end Performance

    }// end Class
}// end Namespace

/*=========================================================================================
 NOTES: a) I wasn't entierly sure how to use ReadAllLines() instead of StreamReader(),
           so my work in part on the following video:
           https://www.youtube.com/watch?v=iwvJ26DTK3w

        b) Had to change these from Lists to Arrays as an 'IndexOutOfBounds' exception
           was thrown, most likely because the List wasn't initialised with any values.
           I'm sure there is a way around this, but I haven't found it yet.

        c) Since we knew there were only two types of data we needed on each row, I
           didn't see the need to create another for loop to itterate through columns.
=========================================================================================*/
