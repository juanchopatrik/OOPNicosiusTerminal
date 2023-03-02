using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverHoulingBinaries1
{
    internal class Person
    {
        private double Salario { get;set; }

        public Person(double salario)
        {
            Salario = salario;
        }

        public static double operator +(Person a, Person b)
        {
            return a.Salario + b.Salario;
        }
    }
}
