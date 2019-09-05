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
            string frase = "The quick brown fox jumps over the lazy dog".ToUpper();
            Console.Write("Ingrese la palabra: ");
           
            string palabra = Console.ReadLine().ToUpper();
           
            for (int i = 0; i < frase.Length - palabra.Length+1; i++)
            {
                string x = "";

                for (int j = 0; j < palabra.Length; j++)
                {

                    x += frase[i + j];

                    if (x == palabra)
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine(palabra + "vs" + x);
                }

            }
        }
    }
    
}
