using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosNicoSius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            CRefri miRefri = new CRefri(70, -20);

            miRefri.AdicionarMetodoReservas(new CRefri.DReservasBajas(InformeKilos));
            miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeKilos));

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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Reservas bajas de alimentos, estoy anivel de main");
            Console.WriteLine($"---> quedan {pGrados}");
        }
    }
}
