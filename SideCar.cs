using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public class SideCar : Vehicle, IVehicle
    {
        public SideCar(int cilindrata, int peso) : base(cilindrata, peso)
        {
        }
    }
}
