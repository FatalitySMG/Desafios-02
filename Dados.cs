using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, dado2 = 0, total = 0, pares = 0, probabilidad = 0, p6 = 0;
            
            string continuar = "s";
            dado = aleatorio.Next(1, 7);
            dado2 = aleatorio.Next(1, 7);
            Console.WriteLine("Sus nuevos dados son" + dado + "y" + dado2);
            total += dado + dado2;
            Console.WriteLine("Su acumulado es: " + total);

            while (continuar == "s")
            {
                Console.WriteLine("¿Desea tirar los dados nuevamente?(s/n)");
                continuar = Console.ReadLine();
                dado = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                probabilidad += 1;
                Console.WriteLine("Sus nuevos dados son" + dado + "y" + dado2);
                total += dado + dado2;
                

                if ((dado == 1 && dado2 == 1))
                {
                    Console.WriteLine("¡Perdiste!, Intenta de nuevo");
                    break;
                }
                else
                {
                    Console.WriteLine("Su acumulado es: " + total);

                }

                if (dado == dado2)
                {
                    pares += 1;
                    Console.WriteLine("Contador: " + pares);
                    if (pares == 3)
                    {
                        Console.WriteLine("¡Felicidades!, Ganaste");
                        break;
                    }
                }
                if (total >= 100)
                {
                    Console.WriteLine("¡Felicidades!, Ganaste");
                    break;
                }
                if ((dado + dado2) > 6)
                {
                    p6 += 1;
                    
                }
            }
            double porcentaje = (p6 * 100) / probabilidad;
            Console.WriteLine("La probabilidad de sacar 6 es: " + porcentaje + "%");
            Console.WriteLine("Gracias por jugar");
            Console.WriteLine("Fin del juego");
        }
    }
}
