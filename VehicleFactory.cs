using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public class VehicleFactory
    {
        public static IVehicle Build(int numberOfWheels, int cilindrata, int peso) => numberOfWheels switch
        {
            2 => cilindrata > 125 ? new Motorbike(cilindrata, peso) : new Scooter(cilindrata, peso),
            3 => new SideCar(cilindrata, peso),
            4 => new Car(cilindrata, peso),   
            6 => peso > 60000 ? new Tir(cilindrata, peso) : new Truck(cilindrata, peso),
            _ => throw new NumberOfWheelsNotSupported()
        };
    }
}
