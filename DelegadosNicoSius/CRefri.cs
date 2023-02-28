using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosNicoSius
{
    internal class CRefri
    {
        public delegate void DReservasBajas(int pKilos);
        public delegate void DDescongelado(int pGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;

        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;

        public int KilosAlimentos { get => kilosAlimentos; }
        public int Grados { get => grados; }

        public CRefri(int kilosAlimentos, int grados)
        {
            this.kilosAlimentos = kilosAlimentos;
            this.grados = grados;
        }

        public void AdicionarMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas = pMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado = pMetodo;
        }
        public void Trabajar(int pConsumo)
        {
            kilosAlimentos -= pConsumo;

            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{kilosAlimentos} kilos, {grados} grados");

            if (kilosAlimentos < 10)
            {
                delReservas(kilosAlimentos);
            }

            if (grados > 0)
            {
                delDescongelado(grados);
            }
        }
    }
}
