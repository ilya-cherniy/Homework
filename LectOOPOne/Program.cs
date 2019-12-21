using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectOOPOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehicle truck = new Truck("Volvo S1", "Volvo", 8000, "Gray", 150);

            truck.ChangeCapacity();
        }
    }
}
