using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafío III");

            //Ingreso de datos
            double c = 56.31 * (Math.PI / 180);
            double z = 3;

            //Calculo de valores
            double t = z / Math.Sin(c);
            double y = Math.Sqrt(t * t - z * z);
            double a = Math.Atan(y / z) * (180 / Math.PI);


            //Imprimir salida
            Console.WriteLine("t es igual a: " + t);
            Console.WriteLine("y es igual a: " + y);
            Console.WriteLine("a es igual a: " + a);
        }
    }
}
