using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class CTiendaAutos
    {
        private CAuto[] disponibles;

        public CTiendaAutos()
        {
            disponibles = new CAuto[4];

            disponibles[0] = new CAuto(220000.5, "Soul");
            disponibles[1] = new CAuto(175600.7, "Fit");
            disponibles[2] = new CAuto(168900.5, "March");
            disponibles[3] = new CAuto(160400.5, "Spark");
        }
        public CAuto this[int index]
        {
            get { return disponibles[index]; }
            set { disponibles[index] = value; }
        }
    }
}
