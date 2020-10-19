/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20

 Description:  1) Creating two car objects and displaying their properties
               2) Making use of the three new Car methods defined in Car Class
                    
 Paramenters: Car1, Car2
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


        }// end Main()
    }// end Class
}// end Namespace
