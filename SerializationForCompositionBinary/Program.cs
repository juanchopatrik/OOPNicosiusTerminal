using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationForCompositionBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine($"1) crear y serializar auto, \n 2) leer auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                string modelo = "";
                double costo = 0;
                int cilindros = 0;
                int hp = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);


                Console.WriteLine("Dame los cilindros");
                valor = Console.ReadLine();
                cilindros = Convert.ToInt32(valor);
                
                Console.WriteLine("Dame los hp");
                valor = Console.ReadLine();
                 hp = Convert.ToInt32(valor);

                CAuto miAuto = new CAuto();
                CMotor miMotor = new CMotor();

                miMotor.Cilindros = cilindros;
                miMotor.Hp = hp;

                miAuto.Modelo  =  modelo;
                miAuto.Costo =  costo;
                miAuto.Motor  =  miMotor;

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                Console.WriteLine("--- Serializamos ---");

                BinaryFormatter formateador = new BinaryFormatter();

                Stream miStream = new FileStream("Autos.au", FileMode.Create,
                    FileAccess.Write, FileShare.None);

                formateador.Serialize(miStream, miAuto);
                miStream.Close();
            }
            
            if (opcion == 2)
            {
                Console.WriteLine("----Deserializamos-----");

                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("Autos.au",
                    FileMode.Open, FileAccess.Read, FileShare.None);

                CAuto miAuto = (CAuto)formateador.Deserialize(miStream);
                miStream.Close();

                Console.WriteLine("El auto deserializado es");
                miAuto.MuestraInformacion();
            }
        }
        }
    }
}
