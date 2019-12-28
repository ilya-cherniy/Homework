using System;
using System.Collections.Generic;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBouquet = new Bouquet { };
            myBouquet.CreateBouquet();
            myBouquet.GetBouquetInfo();
        }
    }
}
