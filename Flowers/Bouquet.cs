using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
    class Bouquet
    {
        public int NumberOfFlowers { get; set; }
        public int Price { get; set; }
        public List<Tulip> Tulip { get; set; }

        public virtual void GetBouquetInfo()
        {
            Console.WriteLine("Bouquet contains {0}{1}", this.NumberOfFlowers, " flowers");
            Console.WriteLine("Bouquet price: {0}", this.Price);
            Console.WriteLine("Bouquet contains following types of tulips:");
            foreach (var flower in this.Tulip)
            {
                Console.WriteLine("* {0}",flower.Type);
            }
        }
    }
}
