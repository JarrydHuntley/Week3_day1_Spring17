using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day1_Spring17
{
    class Car
    {
        public string color;
        public int numOfDoors;
        public int numOfSeats;
        public string make;
        public string model;
        public string VIN;

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
