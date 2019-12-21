using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectOOPOne
{
    class Truck : Vehicle
    {
        public Truck(string model, string manufacturer, int weight, string color, int maxSpeed) :
            base(model, manufacturer, weight, color, maxSpeed)
        {
        }
        public void ChangeCapacity()
        {
            base.Weight = base.Weight + 200;
        }
    }
}
