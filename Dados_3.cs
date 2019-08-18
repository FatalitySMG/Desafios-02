using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dadosVidas
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            Console.WriteLine("Bienvenido al juego, tire el dado cumpliendo las siguientes órdenes:");
            Console.WriteLine("1. Acumule puntos hasta que decida retirarse.");
            Console.WriteLine("2. Cuentas con TRES (3) vidas, pierdes si te quedan en CERO (0).");
            Console.WriteLine("3. Pierdes una vida por cada UNO's que saques en el dado.");
            Console.WriteLine("4. Cuando pierdes una vida, automáticamente pierdes 10 puntos.");
            Console.WriteLine("5. Recuperas una vida al sacar dos SEIS CONSECUTIVOS. NO puedes tener más de tres vidas.");

            int dado = 0, total = 0, vidas = 3, contadorVidas = 0, contadorDobles = 0, contadorUnos = 0;
            string continuar = "s";
            while (continuar == "s")
            {
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Su dado es: " + dado);
                total += dado;
                Console.WriteLine("Su acumulado es: " + total);
               
              
                if(dado == 1)
                {
                    contadorUnos += 1;
                    vidas --;
                    contadorVidas += 1;
                    Console.WriteLine("Ha sacado un uno, contador: " +contadorUnos);
                    Console.WriteLine("Sus vidas son: " + vidas);
                    if (contadorVidas == 3)
                    {
                        Console.WriteLine("¡Perdiste el juego!");
                        break;
                    }
                    total -= 10;

                }
                if (dado == 6)
                {
                    contadorDobles += 1;
                }
                else contadorDobles = 0;
                
                if (contadorDobles == 2)
                {
                    vidas += 1;
                    if (vidas >= 3)
                        vidas = 3;
                    Console.WriteLine("Sus vidas son: " + vidas);
                }
                Console.WriteLine("Desea continuar jugando? (s/n)");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Fin del juego");
        }
    }
}
