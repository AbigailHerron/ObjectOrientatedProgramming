/*#################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 12/10/2020

 Description:  Revision of Methods
 Parameters: Num1, Num2
 #################################################################################################*/
using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            int num1 = 0, num2 = 0;

            Console.Write("Enter first number:  ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number:  ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe sum of all even numbers between {num1} and {num2} is:  {Sum(num1, num2)}");

            
        }// end Main()






        /*---------
        Method: Sum()
                1) Takes in two numbers
                2) Determines which is bigger
                3) Calculates the total of each even number between the two numbers
                4) Returns the sum of all even numbers in this range
         ---------*/
        static private int Sum(int n1, int n2)
        {
            int sum = 0, low = 0, high = 0;

            // Determining which number is bigger
            if (n1 > n2)
            {
                high = n1;
                low = n2;
            }
            else
            {
                low = n1;
                high = n2;
            }// end if block

            // Adding all even numbers together within the range between n1 and n2
            for(int i = low; i <= high; i++)
            {
                if((i % 2) == 0)
                {
                    sum += i;
                }
            }// end for block

            return sum;
        }// end Sum()
    }// end Class
}// end Namespace
