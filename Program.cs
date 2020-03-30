using System;

namespace TheCoffeMechine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COFFE MAKER");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            Milk milk = new Milk(300);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe, water, milk);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            string result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeCappucino();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());

        }

    }
}
