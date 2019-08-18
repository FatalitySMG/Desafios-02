using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine("Bienvenido al juego, tire el dado cumpliendo las siguientes órdenes:");
            Console.WriteLine("1. Acumule puntos hasta que decida retirarse.");
            Console.WriteLine("2. Cuenta con TRES (3) vidas, pierde si le quedan en CERO (0).");
            Console.WriteLine("3. Pierde una vida cada DOS turnos.");
            Console.WriteLine("4. EL jugador usa dos dados cada TRES turnos. Si ambos dados son iguales, se gana una vida");


            int dado = 0, dado2 = 0, total = 0, vidas = 3, contadorVidas = 0, turnos = 0;
            string continuar = "s";
            while (continuar == "s")
            {
                turnos++;
                Console.WriteLine("Turno: " + turnos);
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Su dado es: " + dado);
                total += dado;
                Console.WriteLine("Su acumulado es: " + total);
                
                if ((turnos % 2) == 0)
                {

                    vidas--;
                    contadorVidas += 1;
                    Console.WriteLine("Ha perdido una vida, contador: " + contadorVidas);
                    Console.WriteLine("Sus vidas son: " + vidas);
                    if (contadorVidas == 3)
                    {
                        Console.WriteLine("¡Perdiste el juego!");
                        break;
                    }

                }
                if ((turnos % 3) == 0)
                {
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Su dado2 es: " + dado2);
                    total +=  dado2;
                    Console.WriteLine("Su acumulado es: " + total);
                    if (dado == dado2)
                    {
                        vidas++;
                        contadorVidas--;
                        Console.WriteLine("Sus vidas son: " + vidas);
                    }

                }
                Console.WriteLine("Desea continuar jugando? (s/n)");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Fin del juego.");
        }
    }
}
