using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CTiendaAutos miTienda = new CTiendaAutos();

            CAuto miAuto = miTienda[1];
            miAuto.MuestraInfo();

            CAuto otroAuto = new CAuto(85000, "Vocho");
            miTienda[3] = otroAuto;

            for (int i = 0; i < 4; i++)
            {
                miTienda[i].MuestraInfo();
            }
        }
    }
}
