using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverHoulingBinaries1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario imr;

            imr = im1 + im2;

            Console.WriteLine($"{im1} + {im2} = {imr}");

            imr = im1 - im2;

            Console.WriteLine($"{im1} - {im2} = {imr}");

            imr = im1 * im2;

            Console.WriteLine($"{im1} * {im2} = {imr}");

            imr = im1 / im2;

            Console.WriteLine($"{im1} / {im2} = {imr}");

            Person juan = new Person(10000.0);
            Person ana = new Person(5000.0);

            double salario = juan + ana;
            double prueba = 1 + 2;

            Console.WriteLine($"El salario es = {salario}");
            Console.WriteLine($"La prueba es = {prueba}");

            CImaginario im3 = new CImaginario(1,2);
            CImaginario im4 = new CImaginario (3,4);

            Console.WriteLine(im3);
            im3++;
            Console.WriteLine(im3);
            im3--;  
            Console.WriteLine(im3);

            if (im2 == im3)
                Console.WriteLine("Son Iguales");

            if (im2 == im4)
                Console.WriteLine("Son Diferentes");
        }
    }
}
