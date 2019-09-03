using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_interseción
{
    class Program
    {
        static void Main()
        {
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9 };
            int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 }; 
            int[] I = new int[100];
            int contador2 = 0;

            //Intersección
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        I[contador2] = A[i];
                        contador2++;
                    }
                }
            }
            for (int i = 1; i < I.Length; i++)
            {
                for (int j = i; j < I.Length; j++)
                {
                    if (i != j)
                      if (I[i] == I[j])  I[j] = -1;
                }
            }

            Console.Write("La Intersección de los Conjuntos A y B es: ");
            for (int i = 0; i < contador2; i++)
            {
                if (I[i] != -1) Console.Write(I[i] + ", ");
            }
        }
    }
}
        
    

