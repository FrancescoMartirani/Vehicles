namespace FactoryMethodVehicle
{
    class Program
    {
        static void Main()
        {
            var vehicleWith4wheels = VehicleFactory.Build(4, 2000, 1000);
            Console.WriteLine($"I'm a ... {vehicleWith4wheels.GetType()}");


            var vehicleWith2wheels = VehicleFactory.Build(2, 50, 100);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels.GetType()} and my power is {vehicleWith2wheels.GetPower()}");

            var vehicleWith2wheels2 = VehicleFactory.Build(2, 150, 200);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels2.GetType()}");

            var vehicleWith6wheels = VehicleFactory.Build(6, 6000, 5000);
            Console.WriteLine($"I'm a ... {vehicleWith6wheels.GetType()}");

            var vehicleWith3wheels = VehicleFactory.Build(3, 397, 330);
            Console.WriteLine($"I'm a ... {vehicleWith3wheels.GetType()}");

            var vehicletir = VehicleFactory.Build(6, 6000, 9000);
            Console.WriteLine($"I'm a ... {vehicletir.GetType()}");

            Console.ReadLine();
        }
    }
}