using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectOOPOne
{
    internal class Vehicle
    {

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }

        public Vehicle (string model, string manufacturer, int weight, string color, int maxSpeed)
        {
            Model = model;
            Manufacturer = manufacturer;
            Weight = weight;
            Color = color;
            MaxSpeed = maxSpeed;
        }
        internal PrintInfo()
        {

        }
    }
}
