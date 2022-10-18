using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_JAGS_1124522
{
    class Program
    { 
        class pruebaVector
        {
            private int[] notas;
            public int suma = 0;
            public void Cargar()
            {
                notas = new int[15];
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("Ingresa la nota de tu clase: ");
                    string linea;
                    linea = Console.ReadLine();
                    notas[f] = int.Parse(linea);
                    suma = suma + notas[f];
                }
            }
            public void Imprimir()
            {
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso ");
                    Console.WriteLine(notas[f]);
                }
                Console.WriteLine("La suma de las notas es : " + suma);
                Console.WriteLine("El promedio de las notas es : " + suma / 15);
                Console.ReadKey();
            }

            public void MayoresMenores()
                {
                    int may, men;
                    may = 0;
                    men = 0;
                    for (int f = 0; f < 15; f++)
                    {
                        if (notas[f] > suma)
                        {
                            may++;
                        }
                        else
                        {
                            if (notas[f] < suma)
                            {
                                men++;
                            }
                        }
                    }
                    Console.WriteLine("Cantidad de personas mayores al promedio: " + may); 
                    Console.WriteLine("Cantidad de personas mayores al promedio: " + men);
                    Console.ReadKey();

                }
            static void Main(string[] args)
            {
                Console.WriteLine("SUMA DE NOTAS Y PROMEDIO!");
                pruebaVector pv = new pruebaVector();
                pv.Cargar();
                pv.Imprimir();
                pv.MayoresMenores();
            }
        }

        }
    }

