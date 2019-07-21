using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafío II");

            //Ingreso de datos
            double t = 3.61;
            double aRad = 33.69 * Math.PI / 180;

            //Calculo de valores
            double y = t * Math.Sin(aRad);
            double z = Math.Sqrt(t * t - y * y);
            double c = Math.Atan(z / y) * 180 / Math.PI;

            //Imprimir salida
            Console.WriteLine("y es igual a: " + y);
            Console.WriteLine("z es igual a: " + z);
            Console.WriteLine("c es igual a: " + c);
        }
    }
}
