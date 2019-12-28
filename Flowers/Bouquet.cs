using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
    class Bouquet
    {
        public int NumberOfFlowers { get; set; }
        public int Price { get; set; }
        public List<Flowers> Flowers { get; set; }

        public void CreateBouquet()
        {
            var flowerOne = new Tulip {Price = 10};
            var flowerTwo = new Rose { Price = 30 };
            var flowerThree = new Lily { Price = 12 };
            var flowerFour = new Pion { Price = 7 };
 
            this.Flowers = new List<Flowers> { flowerOne, flowerTwo, flowerThree, flowerFour, flowerFour};

            this.NumberOfFlowers = this.Flowers.Count;
            for (int i = 0; i < this.NumberOfFlowers; i++)
            {
                this.Price += this.Flowers[i].Price;
            }
        }

        public virtual void GetBouquetInfo()
        {
            Console.WriteLine("Bouquet contains {0} flowers", this.NumberOfFlowers);
            Console.WriteLine("Bouquet price: {0}", this.Price);
            Console.WriteLine("Bouquet contains following flowers:");
            foreach (Flowers flower in this.Flowers)
            {
                Console.WriteLine("* {0} - {1}", flower.Name,flower.Price);
            }
        }
    }
}
