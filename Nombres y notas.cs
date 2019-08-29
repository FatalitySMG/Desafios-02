using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            string[] nombres = { "S", "L", "M", "K", "M" };
            int[] notas = { 1, 2, 1, 5, 4 };
            int auxiliar=0;
            string auxiliarNombre = "x";
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = i + 1; j < notas.Length; j++)
                {
                    if (notas[i] < notas[j])
                    {
                        auxiliar = notas[i];
                        notas[i] = notas[j];
                        notas[j] = auxiliar;

                        auxiliarNombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxiliarNombre;
                    }
                }
                Console.WriteLine(notas[i] + " " + nombres[i]);
               // Console.WriteLine(nombres[i]);
            }
           




        }

    }


}
    
