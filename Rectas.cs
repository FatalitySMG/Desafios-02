using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] CoordsX = { 0, 2, 3, 4 };
            double[] CoordsY = { 0, 2, 3, 4 };


            double m = (CoordsY[1] - CoordsY[0]) / (CoordsX[1] - CoordsX[0]);
            double b1 = CoordsY[0] - (m * (CoordsX[0]));
            double d = (Math.Sqrt((Math.Pow(CoordsX[1] - CoordsX[0], 2)) + (Math.Pow((CoordsY[1] - CoordsY[0]), 2))));

            double m2 = (CoordsY[3] - CoordsY[2]) / (CoordsX[3] - CoordsX[2]);
            double b2 = CoordsY[1] - (m2 * (CoordsX[1]));
            double d2 = (Math.Sqrt((Math.Pow(CoordsX[3] - CoordsX[2], 2)) + (Math.Pow((CoordsY[3] - CoordsY[2]), 2))));

            double m3 = (CoordsY[2] - CoordsY[1]) / (CoordsX[2] - CoordsX[1]);
            double b3 = CoordsY[2] - (m3 * (CoordsX[2]));
            double d3 = (Math.Sqrt((Math.Pow(CoordsX[2] - CoordsX[1], 2)) + (Math.Pow((CoordsY[2] - CoordsY[1]), 2))));

            if ((m == m2 && m2 == m3) && (b1 == b2 && b2 == b3))
            {
                Console.WriteLine("Es la misma recta");
            }
            else
            {
                Console.WriteLine("No es la misma recta");
            }

            if (d == d3 && d3 == d2)
            {
                Console.WriteLine("Tienen la misma distancia, ésta es: " + d);
            }
            else
            {
                if (d < d2 && d2 > d3)
                {
                    Console.WriteLine("La distancia más larga es la de la mitad: " + d2);
                }
                else if (d2 < d && d > d3)
                {
                    Console.WriteLine("La distancia más larga es la primera: " + d);
                }
                else
                {
                    Console.WriteLine("La distancia más larga es la última: " + d3);
                }
            }
        }
    }
}
