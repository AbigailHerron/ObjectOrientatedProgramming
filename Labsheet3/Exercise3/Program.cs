/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Revision of Arrays and Methods
 Parameters: randArray
 #################################################################################################*/
using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int[] randArray = new int[4] {35, 22, 89, 9000};

            // Testing values in randArray
            foreach(int num in randArray)
            {
                Console.Write(" " + num);
            }

            // Changing value of randArray elements
            Zero(randArray);


            // Printing new results to screen
            Console.WriteLine();
            foreach(int num in randArray)
            {
                Console.Write(" " + num);
            }
        }// end Main()


        /*---------
         Method: Zero()
                1) Takes an int array
                2) Assigns each element of the array as 0
        ---------*/
        static private void Zero(int[] arry)
        {

            for(int i = 0; i < arry.Length; i++)
            {
                arry[i] = 0;
            }
        }// end Zero()

    }// end Class
}// end Namespace
