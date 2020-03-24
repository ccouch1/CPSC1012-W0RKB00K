using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            this.Make = "Chevrolet";

        }
        public Car(string make, string model, int year, string color, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            OriginalPrice = price;
        }
    }
}
