using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectOOPOne
{
    class SUV : Vehicle
    {
        public SUV(string model, string manufacturer, int weight, string color, int maxSpeed) :
            base(model, manufacturer, weight, color, maxSpeed)
        {
        }
    }
}
