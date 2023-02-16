using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNicosiusTerminal
{
    internal class IEnumerableClass
    {
        public IEnumerableClass()
        {
            CTIendaAutos tienda  = new CTIendaAutos();

            foreach (CAuto miAuto in tienda)
            {
                miAuto.CalculaTenencia(0.05);
                miAuto.MuestraInformacion();
            }
        }
    }
}
