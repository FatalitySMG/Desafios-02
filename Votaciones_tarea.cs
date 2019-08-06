using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_votaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos votos tuvo el partido A? ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántos votos tuvo el partido B? ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántos votos hubo en blanco? ");
            int blancos = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántos votos se anularon? ");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántas personas hay en la población? ");
            int n = int.Parse(Console.ReadLine());
            
          //  Console.WriteLine("¿Qué porcentaje de las personas puede votar? ");
           // int p = int.Parse(Console.ReadLine());
            int votantes = a + b + blancos + anulados;
            //int abste = (n * p / 100) - votantes;

            bool votmen = votantes > n;
            bool dif = Math.Abs(a - b) < 0.10 * votantes;
            bool votmenpo = votantes < 0.30*n;

            if (votmen || (dif && votmenpo))
            {
                Console.WriteLine("Las elecciones deben ser realizadas nuevamente");
            }
            else
            {

            }
                 if ((a > b))
                 {
                    Console.WriteLine("Ganó el partido A");
                 }
                 else
                    Console.WriteLine("Ganó el partido B");
            
              

        }
        
    }
}
