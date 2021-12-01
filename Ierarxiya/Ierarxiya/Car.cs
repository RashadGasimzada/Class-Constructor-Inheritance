using System;
using System.Collections.Generic;
using System.Text;

namespace Ierarxiya
{
    class Car:Vehicle
    {
        public string model;
        public int fuelCapacity;
        public string transmission;

        public Car(string model, int fuelCapacity, string transmission, int kmPerHour, string color, int year) : base(kmPerHour, color, year)
        {
            this.model = model;
            this.fuelCapacity = fuelCapacity;
            this.transmission = transmission;

        }
        public void CarInfo()
        {
            VehicleData();
            Console.WriteLine(this.model);
            Console.WriteLine(this.fuelCapacity);
            Console.WriteLine(this.transmission);
        }
    }
}
