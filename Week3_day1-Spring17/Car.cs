using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day1_Spring17
{
    class Car
    {
        private string color;
        private int numOfDoors;
        private int numOfSeats;
        private string make;
        private string model;
        private string VIN;

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
            get { return this.make; }
        }


        public Car(string color, int numOfDoors, int numOfSeats, string make, string model, string VIN)
        {
            this.color = color;
            this.numOfDoors = numOfDoors;
            this.numOfSeats = numOfSeats;
            this.make = make;
            this.model = model;
            this.VIN = VIN;
        }

    }
}
