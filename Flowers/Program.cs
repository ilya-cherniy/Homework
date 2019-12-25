using System;
using System.Collections.Generic;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBouquet = new Bouquet { };
            var flowerOne = new Tulip { Type = "Christmas Dream", Price = 10 };
            var flowerTwo = new Tulip { Type = "Pink Diamon", Price = 25 };
            var flowerThree = (Tulip)flowerTwo.Clone();
            flowerThree.Price = 15;
            var flowerFour = (Tulip)flowerOne.Clone();
            var flowerFive = new Tulip { Type = "Blushing Beauty", Price = 20 };
            
            myBouquet.Tulip = new List<Tulip> { flowerOne, flowerTwo, flowerThree, flowerFour, flowerFive };
            myBouquet.NumberOfFlowers  = myBouquet.Tulip.Count;
            myBouquet.Price = 0;
            for (int i = 0; i < myBouquet.NumberOfFlowers; i++)
            {
                myBouquet.Price = myBouquet.Price + myBouquet.Tulip[i].Price;
            }
            myBouquet.GetBouquetInfo();
        }
    }
}
