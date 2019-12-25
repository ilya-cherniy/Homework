using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car { Brand = "Volvo", Power = 200, Weight = 1500 };
            var carTwo = new Car { Brand = "Nissan", Power = 150, Weight = 1200 };
            var carThree = (Car)carOne.Clone();
            carThree.GetCarInfo();
            carThree.Power = carThree.ChangePower(carThree.Power);
            Console.WriteLine("Car after modification:");
            carThree.GetCarInfo();
            Console.WriteLine("*********************************");
            var lorryOne = new Lorry { Brand = "Ford", Power = 350, Weight = 3000, Сarrying = 2400 };
            var lorryTwo = (Lorry)lorryOne.Clone();
            lorryTwo.GetCarInfo();
            lorryTwo.Сarrying = lorryTwo.ChangeСarrying(lorryTwo.Сarrying);
            Console.WriteLine("Lorry after modification:");
            lorryTwo.GetCarInfo();
        }
    }
}
