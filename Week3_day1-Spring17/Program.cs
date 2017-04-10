using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day1_Spring17
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Blue", 2, 4, "Toyota", "Celica", "ASD3292939302");

            Console.WriteLine("My car is a " + car1.make + " " + car1.model+ ", and the VIN is " + car1.VIN);

            car1.make = "Dodge";
            car1.model = "Viper";
            car1.VIN = "FJDK29193932932932";

            Console.WriteLine("My car is a " + car1.make + " " + car1.model + ", and the VIN is " + car1.VIN);

        }
    }
}
