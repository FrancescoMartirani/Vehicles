using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public class Scooter : Vehicle, IVehicle
    {
        public Scooter(int cilindrata, int peso) : base(cilindrata, peso)
        {
        }
    }
}
