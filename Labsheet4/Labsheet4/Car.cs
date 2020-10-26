/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20

 Description: Basic car layout
 Properties: Make, Model, Current_Speed and Engine_Size
 Methods: DisplayCarInfo(), ToString() (overrides original ToString()), Accelerate()
 #############################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet4
{
    class Car
    {
        /* Declaring Properties ----------------------------------------------*/
            // make property
        private string make;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

            // model property
        private string model;
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

            // current speed property
        private int currentSpeed;
        public int CurrentSpeed
        {
            get { return this.currentSpeed; }
            set { this.currentSpeed = value; }
        }


            // engin size property
        private double engineSize;
        public double EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }

        /* Declaring Methods -------------------------------------------------*/

        /*---------
        Method: DisplayCarInfo()
                1) Prints the Make, Model, CurrentSpeed and EngineSize 
                   properties to the screen on different lines
        ---------*/
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make: {Make}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Current Speed: {CurrentSpeed}");
            Console.WriteLine($"Engine Size: {EngineSize}");
        }// end DisplayCarInfo()




        /*---------
        Method: ToString()
                1) Overrides the ToString() method
                2) Prints the Make, Model, CurrentSpeed and EngineSize 
                   properties to the screen on different lines
        ---------*/
        public override string ToString()
        {
            return string.Format($"Car Make: {Make}" +
                                 $"\nCar Model: {Model}" +
                                 $"\nCurrent Speed: {CurrentSpeed}" +
                                 $"\nEngine Size: {EngineSize}");
        }// end ToString()


        /*---------
        Method: Accelerate()
                1) Adds 10 to the CurrentSpeed property of the object
                2) Prints the CurrentSpeed of the object to the screen
        ---------*/
        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"Current Speed is {CurrentSpeed}");
        }// end Accelerate()

    }// end Car
}// end Namespace
