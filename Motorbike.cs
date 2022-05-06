using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public class Motorbike : Vehicle, IVehicle
    {
        public Motorbike(int cilindrata, int peso) : base(cilindrata, peso)
        {
        }
    }
}
