using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados2
{
    internal class CTienda
    {
        public static void MandaViveres(int pKilos)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---> Vamos a mandar sus viveres, estoy en la tienda");
            Console.WriteLine($"---> Seran {pKilos}, kilos");
        }
    }
}
