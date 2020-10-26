/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedProgramming/tree/main/Labsheet4

 Description:  1) Creating two car objects and displaying their properties
               2) Making use of the three new Car methods defined in Car Class
               3) a) Creating two bank_account objects using constructor 
                     and displaying their details
                  b) Making use of the methods defined in BancAccount Class
                    
 Paramenters: Car1, Car2, Bnk1, Bnk2
 #############################################################################################*/
using System;

namespace Labsheet4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 1 --------------------------------------------------------------*/
            // creating first Car object
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Focus";
            car1.CurrentSpeed = 0;
            car1.EngineSize = 1.6;

            // creating second Car object
            Car car2 = new Car();
            car2.Make = "Opal";
            car2.Model = "Astro";
            car2.CurrentSpeed = 0;
            car2.EngineSize = 1.2;

            // displaying car properties to the screen
            Console.WriteLine($"The {car1.Make} {car1.Model}, engine size {car1.EngineSize}L is currently traveling at {car1.CurrentSpeed} km/h");
            Console.WriteLine($"The {car2.Make} {car2.Model}, engine size {car2.EngineSize}L is currently traveling at {car2.CurrentSpeed} km/h");


            /* Exercise 2 --------------------------------------------------------------*/
            Console.WriteLine("\n================================================\n"); // new line for neatness
            car2.DisplayCarInfo();
            Console.WriteLine("\n" + car1.ToString() + "\n"); // replaced ToString()

            // Increasing speed 10 times
            for(int i = 0; i <= 10; i++)
            {
                car1.Accelerate();
            }// end for block

            Console.WriteLine($"\nCurrent Speed: {car1.CurrentSpeed}");
            Console.WriteLine($"Current Speed: {car2.CurrentSpeed}"); // showing the difference




            /* Exercise 3 --------------------------------------------------------------*/
            Console.WriteLine("\n================================================\n"); // new line for neatness
            
            // Creating two BankAccount objects, using All constructor
            BankAccount bnk1 = new BankAccount(853463, "John Doe", 207.00);
            BankAccount bnk2 = new BankAccount(123456, "Emily Rose", 500.00);

            // Displaying BankAccount object details
            Console.WriteLine(bnk1.ToString());
            Console.WriteLine("\n" + bnk2);

            // Making use of the Deposit Method
            bnk1.Deposit(103.50);


            // Making use of the Withdraw Method
            bnk2.Withdraw(156.99);

            // Displaying changes
            Console.WriteLine($"\nAccount: {bnk1.AccountNumber} New Balance: {bnk1.Balance}");
            Console.WriteLine($"Account: {bnk2.AccountNumber} New Balance: {bnk2.Balance}");

        }// end Main()
    }// end Class
}// end Namespace
