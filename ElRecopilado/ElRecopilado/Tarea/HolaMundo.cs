using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    public class HolaMundo
    {
        public void HacerMagia()
        {
            Console.WriteLine("Maria Isabel Fragoso Garcia");
            Console.WriteLine("CUH51197169");
            Console.WriteLine("cuh51197169@cuh.mx");
              class Program
        {
            class Matriz
            {

                public int[,] Generador(int tamaño)
                {
                    int[,] matrizgenerada = new int[tamaño, tamaño];
                    Random random = new Random();
                    int suma_izq = 0, suma_der = 0;
                    Console.WriteLine("Matriz  Aleatoria :)");
                    for (int a = 0; a < tamaño; a ++)
                    {
                        for (int b = 0; b < tamaño; b ++)
                        {
                            matrizgenerada[a, b] = random.Next(-50, 50);
                            Console.Write(matrizgenerada[a, b] + "   ");

                        }
                        Console.WriteLine();

                    }
                    Console.Write("Diagonal Izq");
                    for (int a = 0; a < tamaño; a ++)
                    {
                        Console.Write(" " + matrizgenerada[a, a]);
                        suma_izq = suma_izq + matrizgenerada[a, a];
                    }
                    int z = tamaño - 1;
                    Console.WriteLine();
                    Console.Write("Diagonal Dere");
                    for (int a = 0; a < tamaño; a ++)
                    {

                        suma_der = suma_der + matrizgenerada[a, x];
                        Console.Write(" " + matrizgenerada[a, x]);
                        z = tamaño - 1;

                    }
                    Console.WriteLine("");
                    Console.WriteLine("Suma Izq " + suma_izq);
                    Console.WriteLine("Suma der " + suma_der);
                    int dif = suma_izq - suma_der;
                    int abs;
                    if (dif < 0)
                    {
                        abs = -dif;
                    }
                    else
                    {
                        abs = dif;
                    }
                    Console.WriteLine("dif " + dif);
                    Console.WriteLine("Suma " + (suma_der + suma_izq));

                    return matrizgenerada;
                }

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Introduzca el tamaño de la matriz 'Cuadrada'");
                String texto;
                texto = Console.ReadLine();
                int Tamaño = Int32.Parse(texto);
                Matriz Mt = new Matriz();
                Mt.Generador(Tamaño);


            }
        }
    }
}
    }
}
