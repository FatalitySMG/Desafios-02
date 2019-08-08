using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();

            int total = 0;
            string seguir = "s";
            int carta_1 = aleatorio.Next(1, 11);
            int carta_2 = aleatorio.Next(1, 11);

            Console.WriteLine("Bienvenido al juego, para ganar, debe sacar 21 en el valor total de las cartas que solicites.");
            Console.WriteLine("Sus cartas iniciales son: " + carta_1 + " y " + carta_2);
            total = carta_1 + carta_2;
            Console.WriteLine("Su acumulado es: " + total);

            while (seguir == "s" && total<21)
            {

                Console.Write("Desea otra carta? (s/n) ");
                seguir = Console.ReadLine();
                carta_1 = aleatorio.Next(1, 11);
                Console.WriteLine("Su nueva carta es: " + carta_1);
                total += carta_1;
                Console.WriteLine("Su acumulado es: " + total);

                if (total < 21)
                {
                    Console.Write("¿Desea otra carta? (s/n) ");
                    seguir = Console.ReadLine();

                    Console.WriteLine("Su nueva carta es: " + carta_1);
                    total += carta_1;

                    Console.WriteLine("Su acumulado es: " + total);

                    if (total == 21) Console.WriteLine("¡Ha ganado!");

                }
                else
                {
                      Console.WriteLine("Ha sido eliminado.");
                }
                    
            }
           // Console.WriteLine("Fin del juego.");

        }
    }
}
