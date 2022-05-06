using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    public abstract class Vehicle : IVehicle
    {
        private int Cilindrata;
        private int Peso;

        public Vehicle(int cilindrata, int peso)
        {
            Cilindrata = cilindrata;
            Peso = peso;

        }

        public int GetPower() => Cilindrata;
        public int GetPeso() => Peso;

    }
}
