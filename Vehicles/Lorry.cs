using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Lorry : Car
    {
        public int Сarrying { get; set; }

        public int ChangeСarrying (int Сarrying)
        {
            Сarrying = Сarrying - 200;
            return Сarrying;
        }

        public override void GetCarInfo()
        {
            base.GetCarInfo();
            Console.WriteLine("Carrying: {0}", Сarrying);
        }
    }
}
