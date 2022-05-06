using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public class Car : Vehicle, IVehicle
    {
        public Car(int cilindrata, int peso) : base(cilindrata, peso)
        {
        }
    }
}
