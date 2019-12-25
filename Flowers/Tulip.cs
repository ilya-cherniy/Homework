using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
    class Tulip : ICloneable
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
