using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNicosiusTerminal
{
    internal class CAuto : IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string modelo,double costo )
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void CalculaTenencia(double imp)
        {
            this.tenencia = 5000.0 + this.costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu automovil {modelo}");
            Console.WriteLine($"Costo {costo}, con una tenencia de {tenencia}");
            Console.WriteLine($"Total {costo + tenencia}");
            Console.WriteLine($"--------------------------");

        }
    }
}
