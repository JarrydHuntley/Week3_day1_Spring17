using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day1_Spring17
{
    class Car
    {
        //fields
        private string color;
        private int numOfDoors;
        private int numOfSeats;
        private string make;
        private string model;
        private string VIN;

        //properties
        public string Color
        {
            get { return this.color; }
            set
            {
                if (value.ToLower() == "green")
                {
                    color = "Blue";
                }
                else
                {
                    color = value;
                }
            }
        }

        public string Make
        {
            get { return this.make;}
        }

        public string CarName
        {
            get { return this.make + " " + this.model; }
        }

        //constructors
        public Car(string color, int numOfDoors, int numOfSeats, string make, string model, string VIN)
        {
            this.color = color;
            this.numOfDoors = numOfDoors;
            this.numOfSeats = numOfSeats;
            this.make = make;
            this.model = model;
            this.VIN = VIN;
        }

        //methods

        public void PrintCarInfo()
        {
            Console.WriteLine("This car is a " + CarName + "that is " + color);
            Console.WriteLine("It has " + numOfDoors + "and " + numOfSeats);
            Console.WriteLine("The VIN is " + VIN);
        }


    }
}
