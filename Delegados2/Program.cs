using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            CRefri miRefri = new CRefri(70, -20);

            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);
            DDescongelado desc1 = new DDescongelado(InformeGrados);

            miRefri.AdicionarMetodoReservas(kilos1);
            miRefri.AdicionarMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(desc1);

            while (miRefri.KilosAlimentos > 0)
            {
                miRefri.Trabajar(rnd.Next(1,5));
            }

            miRefri.EliminaMetodoReservas(kilos2);

            miRefri.KilosAlimentos = 50;
            miRefri.Grados = -15;

            while (miRefri.KilosAlimentos > 0)
            {
                miRefri.Trabajar(rnd.Next(1,5));
            }
        }


        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Reservas bajas de alimentos, estoy anivel de main");
            Console.WriteLine($"---> quedan {pKilos}");
        }

        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---> Se descongela el refri, ");
            Console.WriteLine($"---> quedan {pGrados}");
        }
    }
}
