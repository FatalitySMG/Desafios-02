using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual: ");
            double s = double.Parse(Console.ReadLine());
            int SMMLV = 828116;

            if (s < 2 * SMMLV)
            {
                Console.WriteLine("Su Tarifa correspone a la A");
            }
            else if (2 * SMMLV <= s && s < 4 * SMMLV)
            {
                Console.WriteLine("Su Tarifa correspone a la B");
            }
            else
            {
                Console.WriteLine("Su Tarifa correspone a la C");
            }

                   

            

        }
    }
}
