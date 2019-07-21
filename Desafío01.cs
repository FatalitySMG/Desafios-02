using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_01
{
    class Program
    {
        static void Main(string[] args) {

         
            {
                Console.WriteLine("Desafío I");

                //Ingreso de datos
                double y = 2;
                double z = 3;

                //Calculo de valores
                double t = Math.Sqrt(y * y + z * z);
                double c = (Math.Atan(z / y)) * (180 / Math.PI);
                double a = (Math.Asin(y / t)) * (180 / Math.PI);



                //Imprimir salida
                Console.WriteLine("t es igual a: " + t);
                Console.WriteLine("c es igual a: " + c);
                Console.WriteLine("a es igual a: " + a);

            }





        }

    }
}
