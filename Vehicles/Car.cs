using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Car : ICloneable
    {
        public string Brand { get; set; }
        public int Weight { get; set; }
        public int Power { get; set; }

        public int ChangePower(int Power)
        {
            Power = Power + 500;
            return Power;
        }

        public virtual int ChangeСarrying(int Сarrying)
        {
            return Сarrying;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public virtual void GetCarInfo()
        {
            Console.WriteLine("Brand: {0}",Brand);
            Console.WriteLine("Weight: {0}", Weight);
            Console.WriteLine("Power: {0}", Power);
        }
    }
}
