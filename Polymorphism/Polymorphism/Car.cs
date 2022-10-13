using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car : Vehicle
    {

        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public DateTime Year { get; set; }

        public Car(string id, string color, string model, string make, DateTime year)
        {
            Color = color;
            Model = model;
            Make = make;
            Year = year;
            ID = id;
        }

        public override void Drive()
        {
            Console.WriteLine($"VROOOOM I'm a {Make} {Model}!");
        }
    }
}
