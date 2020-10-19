/*#############################################################################################
 Name: Abigail Herron
 ID: s00200536
 Date: 19/10/20

 Description: Basic car layout
 Properties: Make, Model, Current_Speed and Engine_Size
 #############################################################################################*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Labsheet4
{
    class Car
    {
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

    }// end Car
}// end Namespace
