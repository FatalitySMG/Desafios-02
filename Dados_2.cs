using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados2
{
    class Program
    {
        static void Main()

        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, turnos = 0, contador12 = 0, contador10 = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                turnos += 1;
                Console.WriteLine("Turno: " + turnos);
                dado = aleatorio.Next(10, 13);
                Console.WriteLine("El número sacado fue" + dado);
                total += dado;
                Console.WriteLine("Lleva un total de: " + total);

                if (turnos >= 3)
                {
                    Console.WriteLine(" Desea tirar los dados nuevamente (s/n) ?");
                    continuar = Console.ReadLine();
                    //total += dado;
                    //Console.WriteLine("Lleva un total de: " + total);
                    

                    if ((dado % 2) == 0) //Par
                    {
                        total += dado;
                        Console.WriteLine("Lleva un total de: " + total);

                        if (dado == 12)
                        {
                            contador12 = 1;
                           
                        }
                        if (contador12 == 1)
                        {
                            if (dado == 10) contador10 = 1;
                            else contador10 = 0;
                        }
                        if (contador12 + contador10 == 2)
                        {
                            Console.WriteLine("¡Felicidades!, Sacaste un 10 seguido de un 12, ¡GANASTE!");
                            break;
                        }

                       

                    }
                    else //Impar
                   {
                     Console.WriteLine("¡Sacaste un número impar!, ¡PERDISTE!");
                     total += 0;
                     Console.WriteLine("Total: " + total);
                     break;
                   }

                }
                if (total >= 100)
                {
                    Console.WriteLine("¡Felicidades!, ¡GANASTE!");
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    break;
                }

            }
        }
    }
}
