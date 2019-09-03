using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] I = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9 };
            int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 };
            int[] U;
            int contador = 0, contador1 = 0;

            bool existe = false;
            bool existe1 = false;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j]) existe = true;
                }
                if (existe == false) contador++;
                else existe = false;
            }

            U = new int[B.Length + contador];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j]) existe1 = true;
                }
                if (existe1 == false)
                {
                    U[contador1] = A[i];
                    contador1++;
                }
                else existe1 = false;
            }

            for (int z = 0; z < B.Length; z++)
            {
                U[contador1] = B[z];
                contador1++;
            }
            for (int i = 1; i < U.Length; i++)
            {
                for (int j = i; j < U.Length; j++)
                {
                    if (i != j)
                        if (U[i] == U[j]) U[j] = -1;
                }
            }


            //Complemento
            Console.WriteLine("El Complemento es: ");
            bool existe2 = false;
            for (int i=0; i< I.Length; i++)
            {
                existe2 = false;
                for (int j=0; j <U.Length; j++)
                {
                    if (U[j] == I[i]) existe2 = true;
                }
                
                if (existe2== false)
                {
                  
                    Console.Write( I[i] + ", ");
                }
            }

        }
    }
}