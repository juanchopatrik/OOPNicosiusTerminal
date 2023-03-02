using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class CAuto
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(double costo, string modelo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void MuestraInfo()
        {
            Console.WriteLine($"Tu automovil {modelo}");
            Console.WriteLine($"Costo {costo}");
            Console.WriteLine("------------------------");
        }
    }
}
