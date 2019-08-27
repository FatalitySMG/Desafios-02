using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cuántos datos se tienen?");
            int n = int.Parse(Console.ReadLine());
            int max = 0, min = 150; 
            double min2 = 1000000;
            string nombreMax = "x";
            string nombreMin = "y";
            double total = 0;
            double sumatoria = 0;
            double desviación = 0;
            string nombre3 = "z";

            int[] edades = new int[n];       // Arreglo edades.
            string[] nombre = new string[n]; // Arreglo nombres.

            for (int i = 0; i < edades.Length; i++) // Ciclo para pedir datos.
            {
                Console.Write("Ingrese el nombre: "); // Nombre
                nombre[i] = Console.ReadLine(); // Se guarda el nombre en la posición i.

                Console.Write("Ingrese la edad: "); // Edad.
                edades[i] = int.Parse(Console.ReadLine()); // Se guarda la edad en la posición i.

                if (edades[i] > max)
                {
                    max = edades[i];
                    nombreMax = nombre[i];  
                }
                if (edades[i] < min)
                {
                    min = edades[i];
                    nombreMin = nombre[i];
                }

                total += edades[i];
            }

            Console.WriteLine(total);
            double promedio = total / edades.Length;

            for (int i = 0; i < edades.Length; i++)
            {
                int xi = edades[i];
                sumatoria += Math.Pow((xi - promedio), 2);
                double nombreCerc= Math.Pow(edades[i] - promedio,2);
                if(nombreCerc < min2)
                {
                    min2 = nombreCerc;
                    nombre3 = nombre[i];
                }

            }
            desviación = Math.Sqrt(sumatoria / n);
            Console.WriteLine("La desviación es: " + desviación);
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("El mayor es: " + nombreMax + ", con una edad de: " + max);
            Console.WriteLine("El menor es: " + nombreMin + ", con una edad de: " + min);
            Console.WriteLine("La persona con la edad más cercana al promedio es: " + nombre3);

        }    
    }
}
