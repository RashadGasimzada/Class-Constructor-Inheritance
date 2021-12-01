using System;
using System.Collections.Generic;
using System.Text;

namespace Ierarxiya
{
    class Vehicle
    {
        public int kmPerHour;
        public string color;
        public int year;

        public Vehicle(int kmPerHour, string color, int year)
        {
            this.kmPerHour = kmPerHour;
            this.color = color;
            this.year = year;
        }
        public void VehicleData()
        {
            Console.WriteLine(this.kmPerHour);
            Console.WriteLine(this.color);
            Console.WriteLine(this.year);
        }
    }
}
