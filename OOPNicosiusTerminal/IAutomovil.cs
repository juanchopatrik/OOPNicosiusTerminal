using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IITERBLE
{
    internal interface IAutomovil
    {
        //int Algo { get; set; }
        void CalculaTenencia(double imp);

        void MuestraInformacion();
    }
}
