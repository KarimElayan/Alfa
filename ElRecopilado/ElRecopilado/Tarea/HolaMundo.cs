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
        }

            namespace Practica5
    {
        class Program
        {
            static void Main(string[] args)
            {
                int indiceFila, indiceCol, tamFilasCol;
                Console.WriteLine("Matriz De usuario");
                Console.WriteLine("Favor de usar un rango entre el 2 y el 100 para usar la matriz");
                Console.WriteLine("y");
                Console.WriteLine("Tambien usar un rango de numeros entre el -50 y el 50 para usar el programa");

                Console.WriteLine("¿Cuantas Filas y Columnas tendra tu matriz?");
                tamFilasCol = Convert.ToInt32(Console.ReadLine());


                int[,] matrizUsuario = new int[tamFilasCol, tamFilasCol];

                if (tamFilasCol >= 2 && tamFilasCol <= 100)
                {

                    for (indiceFila = 0; indiceFila < tamFilasCol; indiceFila++)
                    {
                        for (indiceCol = 0; indiceCol < tamFilasCol; indiceCol++)
                        {
                            Console.Write("Ingresa el dato del indice [" + indiceFila + "," + indiceCol + "]: ");
                            matrizUsuario[indiceFila, indiceCol] = Convert.ToInt32(Console.ReadLine());

                        }
                    }


                    Console.WriteLine("Los Datos que ingresaste son: ");
                    for (indiceFila = 0; indiceFila < tamFilasCol; indiceFila++)
                    {
                        for (indiceCol = 0; indiceCol < tamFilasCol; indiceCol++)
                        {
                            Console.Write(matrizUsuario[indiceFila, indiceCol] + "," + " ");

                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Write("Numero Fuera de Rango. Solo Rangos del 2 al 100. Vuelve a Iniciar el programa.");
                };



            }
        }
    }


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
