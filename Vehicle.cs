using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public abstract class Vehicle : IVehicle
    {
        public int Cilindrata;
        public int Peso;

        public Vehicle(int cilindrata, int peso)
        {
            Cilindrata = cilindrata;
            Peso = peso;

        }

        public int GetPower() => Cilindrata;

    }
}
