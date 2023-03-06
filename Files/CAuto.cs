using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class CAuto
    {
        private double costo;
        private string modelo;

        public CAuto(double costo, string modelo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu automovil {modelo}");
            Console.WriteLine($"Costo {costo}");
            Console.WriteLine($"--------------------");
        }
    }
}
