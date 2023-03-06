using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationCompositionXML
{
    [Serializable]
    internal class CAuto
    {

        private double costo;
        private string modelo;
        private CMotor motor;

        public CAuto()
        {
            costo = 100000.0;
            modelo = "Volvo";
            motor = new CMotor();
        }

        public CAuto(double costo, string modelo, int pCilindro, int pHP )
        {
            this.costo = costo;
            this.modelo = modelo;
            motor = new CMotor(pCilindro, pHP);
        }

        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        internal CMotor Motor { get => motor; set => motor = value; }

        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu automovil {modelo}");
            Console.WriteLine($"Costo {costo}");
            motor.MuestraMotor();
            Console.WriteLine($"--------------------");
        }
    }
}
