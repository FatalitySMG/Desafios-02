using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjackeste_si_es_original
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para ganar, debe sacar 21 en el valor total de las cartas que solicites.");

            Random aleatorio = new Random();

            int jugador = 0, max = 0;
            string nmax = "x";

            Console.WriteLine("Ingrese el numero de jugadores (minimo 2, máximo 5)");
            int jugadores = int.Parse(Console.ReadLine());

            while (jugadores < 2 || jugadores > 5)
            {
                Console.WriteLine("Error. Mínimo DOS (2) jugadores y máximo CINCO (5)");
                jugadores = int.Parse(Console.ReadLine());
            }

            while (jugador < jugadores)
            {
                jugador++;
                Console.WriteLine("Bienvenido jugador:" + jugador);
                Console.Write("Ingrese su nombre: ");
                string nombre = (Console.ReadLine());

                int carta1 = 0, carta2 = 0, total = 0, carta = 0;
                string continuar = "s";

                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;
                Console.WriteLine("Sus cartas son: " + carta1 + " y " + carta2);
                Console.WriteLine("Su acumulado es: " + total);

                while (continuar == "s" && total < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    Console.WriteLine("Su nueva carta es:  " + carta);
                    total += carta;
                    Console.WriteLine("Total: " + total);

                    if (total < 21)
                    {
                        Console.Write("Deseas continuar? (s/n): ");
                        continuar = Console.ReadLine();
                        while (continuar != "s" && continuar != "n")
                        {
                            Console.Write("¡Error!, Deseas continuar? (s/n): ");
                            continuar = Console.ReadLine();
                        }
                        
                        if (total > max) max = total;
                        if (total == max) nmax = nombre;
                    }
                    else
                    {
                        Console.WriteLine("¡Ha sido eliminado!");
                        total = 0;
                        Console.WriteLine("Su Total fue: " + total);
                        break;

                        //if (total == 21) Console.WriteLine("¡Ha ganado!");
                    }
                    if (total == 21) Console.WriteLine("¡Ha ganado!");

                }


                Console.WriteLine("Gracias por jugar.");
            }
            Console.WriteLine("El Ganador fue: " + nmax);
        }
        
    }
}
