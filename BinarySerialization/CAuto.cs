using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;

        public CAuto(double costo, string modelo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu automovil {modelo}");
            Console.WriteLine($"Costo {costo}");
            Console.WriteLine($"--------------------");
        }
    }
}
