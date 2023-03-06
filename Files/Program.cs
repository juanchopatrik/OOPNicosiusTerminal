using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Files
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

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto miAuto = new CAuto(costo, modelo);

                int numero = 5;
                bool acceso = false;
                byte conteo = 120;

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                Console.WriteLine("--- Serializamos ---");


                FileStream miStream = new FileStream("MiArchivo.arc", FileMode.Create,
                    FileAccess.Write, FileShare.None);

                BinaryWriter writer = new BinaryWriter(miStream);

                writer.Write(miAuto.Modelo);
                writer.Write(miAuto.Costo);

                writer.Write(numero);
                writer.Write(acceso);
                writer.Write(conteo);

                miStream.Close();
            }

            if (opcion == 2)
            {
                Console.WriteLine("----Deserializamos-----");

                Stream miStream = new FileStream("MiArchivo.arc",
                    FileMode.Open, FileAccess.Read, FileShare.None);

                BinaryReader reader = new BinaryReader(miStream);

                string modelo = "";
                double costo = 0;
                int numero = 0;
                bool acceso = true;
                byte conteo = 0;

                modelo = reader.ReadString();
                costo = reader.ReadDouble();
                CAuto miAuto = new CAuto(costo, modelo);

                numero = reader.ReadInt32();
                acceso = reader.ReadBoolean();
                conteo = reader.ReadByte();

                miStream.Close();

                miAuto.MuestraInformacion();
                Console.WriteLine($"numero : {numero}");
                Console.WriteLine($"acceso : {acceso}");
                Console.WriteLine($"conteo : {conteo}");
            }
        }
    }
}
