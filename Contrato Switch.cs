using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de deducciones salariales");
            Console.WriteLine("Ingrese su salario actual: ");
            double salario = int.Parse(Console.ReadLine());


             //int SMMLV = 828116;
            double BC = salario * 0.40;
            double BON = 0;
            double PEN = 0;
            double EPS = 0;
            double r1 = (0.522 / 100);
            double r2 = (1.044 / 100);
            double r3 = 2.436 / 100;
            double r4 = 4.350 / 100;
            double r5 = 6.960 / 100;
            double ARL = 0;
            
            Console.WriteLine("Si su contrato es dependiente, ingrese D");
            Console.WriteLine("Si su contrato es independiente, ingrese I");
            string Cont = Console.ReadLine();

            switch (Cont)
            {
                case ("I"):
                    Console.WriteLine("Ingrese de 1 a 5, el equivalente a la clase de riesgo de su trabajo: ");
                    int riesgo = int.Parse(Console.ReadLine());
                    switch (BC)
                    {

                        case (828116):
                            switch (riesgo)
                            {
                                case (1):
                                    ARL = r1 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                case (2):
                                    ARL = r2 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                case (3):
                                    ARL = r3 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                case (4):
                                    ARL = r4 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                default:
                                    ARL = r5 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                            }
                            break;
                        default:
                            
                            switch (riesgo)
                            {
                                case (1):
                                    ARL = r1 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                case (2):
                                    ARL = r2 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                case (3):
                                    ARL = r3 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                case (4):
                                    ARL = r4 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                                default:
                                    ARL = r5 * BC;
                                    EPS = BC * 0.125;
                                    PEN = BC * 0.16;
                                    break;
                            }
                                    break;
                            
                    }
                    break;
                default:
                    EPS = BC * 0.04;
                    PEN = BC * 0.04;
                    BON = salario;
                    break;
            }

            double salarioFinal = salario - (ARL + PEN + EPS);
            double salarioAnual = (salarioFinal * 12) + BON;
            Console.WriteLine("Su salario es: " + salarioFinal);
            Console.WriteLine("Su ARL es: " + ARL);
            Console.WriteLine("Su Pensión es: " + PEN);
            Console.WriteLine("Su EPS es: " + EPS);
            Console.WriteLine("Su Bonificación es: " + BON);
            Console.WriteLine("Su salario anual es " + salarioAnual);

        }
    }
}
