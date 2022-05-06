using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodVehicle
{
    [Serializable]
    internal class NumberOfWheelsNotSupported : Exception
    {
        public NumberOfWheelsNotSupported()
        {
        }

        public NumberOfWheelsNotSupported(string message) : base(message)
        {
        }
    }
}