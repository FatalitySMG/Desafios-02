using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuotaMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual: ");
            double s = double.Parse(Console.ReadLine());
            int SMMLV = 828116;
            double A = 3200;
            double B = 12700;
            double C = 33500;

            if (s < 2 * SMMLV)
            {
                Console.WriteLine("Su Tarifa corresponde a la A, y su cuota mensual corresponde a (COP): " + A);
            }
            else if (2 * SMMLV <= s && s < 5 * SMMLV)
            {
                Console.WriteLine("Su Tarifa corresponde a la B, y su cuota mensual corresponde a (COP): " + B);
            }
            else
            {
                Console.WriteLine("Su Tarifa corresponde a la C, y su cuota mensual corresponde a (COP): " + C);
            }
        }
    }
}
