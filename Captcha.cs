using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int a = 0, b = 0, sumaCorrecta = a + b, suma = 0, intentos = 3;

            while(intentos > 0)
            {
                a = aleatorio.Next(1, 10);
                b = aleatorio.Next(1, 10);
                sumaCorrecta = a + b;
                Console.WriteLine("Cuánto es " + a + "+" + b);
                suma = int.Parse(Console.ReadLine());

                if (sumaCorrecta != suma)
                {
                    Console.WriteLine("Incorrecto.");
                    intentos--;
                    if (intentos <= 0) Console.WriteLine("Acceso negado, bloqueando dispositivo...");
                }
                else
                {
                    Console.WriteLine("Acceso concedido");
                    break;
                }
                Console.WriteLine("Solo hago esto para el trabajo de scripting");
            }

        }
    }
}
