using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationForCompositionBinary
{
    [Serializable]
    internal class CMotor
    {
        private int cilindros;
        private int hp;


        public int Cilindros { get => cilindros; set => cilindros = value; }
        public int Hp { get => hp; set => hp = value; }

        public CMotor(int cilindros, int hp)
        {
            this.cilindros = cilindros;
            this.hp = hp;
        }

        public CMotor()
        {
            cilindros = 4;
            hp = 200;
        }

        public void MuestraMotor()
        {
            Console.WriteLine($"==== Ciilindros: {cilindros}, HP:{hp}");
        }
    }
}
