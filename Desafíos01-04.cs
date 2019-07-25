using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafíos_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            //Ingreso de Datos
            // Console.WriteLine("Hallar el valor de X");
            // double b = 19.44;
            // double z = 3;
            // double y = 2;

            //Calculo de datos
            // double c = Math.Atan(z / y)* 180/Math.PI;
            // double a = Math.Atan(y / z)* 180/Math.PI;
            // double d = 180 - (90 + a + b) ;
            // double w = z / Math.Sin(d * Math.PI / 180) * Math.Sin(90 * Math.PI / 180);
            // double x = (z * Math.Sin((a + b) * (Math.PI / 180)) / (Math.Sin(d * Math.PI / 180))) - y;

            //Console.WriteLine("x es igual a:  " + x);

            //Ejercicio 2

            //Ingreso de datos
            //Console.WriteLine("Hallar el valor de z");
            //double d = 36.87;
            //double b = 19.44;
            //double y = 2;

            //Calculo de datos
            //double a = 180 - (90 + d + b);
            //double c = 180 - (90 + a);
            //double z = (y * Math.Sin(c * (Math.PI / 180))) / (Math.Sin(a * (Math.PI / 180)));

            //Console.WriteLine("z es igual a:  " + z);

            //Ejercicio 3

            //Ingreso de datos
            //Console.WriteLine("Hallar el valor de y");
            //double w = 5;
            //double d = 36.87;
            //double x = 2;

            //Calculo de datos
            //double z = w * ((Math.Sin(d * (Math.PI / 180)))) / (Math.Sin(90 * Math.PI / 180));
            //double xy = Math.Sqrt(w * w - z * z);
            //double y = xy - x;

            //Console.WriteLine("y es igual a:  " + y);

            //Ejercicio 4

            //Ingreso de datos 
            Console.WriteLine("Hallar el valor de x");
            double w = 5;
            double t = 3.61;
            double c = 56.31;

            //Calculo de datos
            double z = (t*Math.Sin(c*Math.PI/180))/(Math.Sin(90*Math.PI/180));
            double y = Math.Sqrt(t * t - z * z);
            double x = (Math.Sqrt(w * w - z * z)) - y;

            Console.WriteLine("x es igual a:  " + x);

        }
    }
}
