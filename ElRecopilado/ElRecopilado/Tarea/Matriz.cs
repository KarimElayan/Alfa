using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Tarea
{
    class Matriz
    {
        public void MatrizTarea()
        {
            string[,] matrizDeLetras = new string[,]
           {
                {"G","Q","Y","X","F","C","O","N","S","O","L","E","W","A"},
                {"B","Z","T","B","C","Y","D","U","A","R","R","S","A","R"},
                {"P","X","U","N","F","Y","M","J","H","Y","G","T","L","R"},
                {"X","Y","H","S","I","N","T","A","X","I","S","R","G","E"},
                {"R","N","H","J","Y","Y","Q","V","V","M","Q","I","O","G"},
                {"D","O","U","B","L","E","O","L","X","U","O","N","R","L"},
                {"A","T","R","D","F","M","O","F","H","D","K","G","I","O"},
                {"T","T","A","N","L","O","F","M","Y","T","E","S","T","K"},
                {"D","C","K","C","O","I","S","W","T","H","K","C","M","O"},
                {"H","W","O","L","A","E","X","T","H","B","R","H","O","C"},
                {"I","N","T","A","T","L","Z","R","R","O","L","A","R","L"},
                {"S","K","Z","S","M","C","A","P","E","O","T","R","H","Z"},
                {"Q","X","F","S","P","O","C","S","I","L","S","J","F","O"},
                {"N","Q","I","P","Z","F","#","B","C","A","X","D","Y","Q"}
           };


            Console.WriteLine("Impresion de arreglo de manera ordinaria");
            for (int x = 0; x < 14; x++)
            {
                for (int y = 0; y < 14; y++)
                {
                    Console.Write(matrizDeLetras[x, y] + " , "); //se puso una coma para alejar las letras.
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nImpresion de arreglo de manera invertida"); //se puso un slash y n para salto de linea
            for (int i = 13; i > -1; i--)
            {
                for (int j = 13; j > -1; j--)
                {
                    Console.Write(matrizDeLetras[i, j] + ((j == 0) ? "" : " , "));//se puso para quitar las comas al final. Dicelo sigiuiente si j es igual a cero imprimir nada y si es falso imprimir una coma.
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Impresion de la matris remplazando y evaluando las condiciones");
            int suma1 = 0;
            int suma2 = 0;
            int suma3 = 0;
            int suma4 = 0;
            for (int m = 0; m < 14; m++)
            {
                for (int n = 0; n < 14; n++)
                {
                    string sol1 = matrizDeLetras[m, n];

                    if (sol1 == "F")
                    {
                        suma4 = suma4 + 1;
                    }
                    if (sol1 == "#")
                    {
                        suma3 = suma3 + 1;
                    }

                    if (sol1 == "A" || sol1 == "E" || sol1 == "I" || sol1 == "O" || sol1 == "U")
                    {
                        sol1 = sol1.ToLower();
                        suma1 = suma1 + 1;
                        suma2 = suma2 + 1;
                    }
                    if (sol1 == "B")
                    {
                        sol1 = "2";
                        suma1 = suma1 + 1;
                    }
                    if (sol1 == "X")
                    {
                        sol1 = "9";
                        suma1 = suma1 + 1;
                    }
                    if (sol1 == "Z" || sol1 == "C")
                    {
                        sol1 = "%";
                        suma1 = suma1 + 1;
                        suma3 = suma3 + 1;
                    }
                    if (sol1 == "T")
                    {
                        sol1 = "5";
                        suma1 = suma1 + 1;
                    }

                    Console.Write(sol1 + " , ");

                }
                Console.WriteLine();
            }

            int suma5 = 0;
            int suma6 = 0;
            int suma7 = 0;
            int suma8 = 0;


            //columna 1
            for (int x = 0; x < 14; x++)
            {
                string sol2 = matrizDeLetras[x, 0];
                if (sol2 == "A" || sol2 == "E" || sol2 == "I" || sol2 == "O" || sol2 == "U")
                {

                    suma5 = suma5 + 1;
                }
            }
            //columna 2
            for (int y = 0; y < 14; y++)
            {
                string sol3 = matrizDeLetras[y, 1];
                if (sol3 == "A" || sol3 == "E" || sol3 == "I" || sol3 == "O" || sol3 == "U")
                {

                    suma6 = suma6 + 1;
                }
            }
            //columna 3
            for (int t = 0; t < 14; t++)
            {
                string sol4 = matrizDeLetras[t, 2];
                if (sol4 == "A" || sol4 == "E" || sol4 == "I" || sol4 == "O" || sol4 == "U")
                {

                    suma7 = suma7 + 1;
                }
            }
            //columna 14

            for (int t = 0; t < 14; t++)
            {
                string sol5 = matrizDeLetras[t, 13];

                if (sol5 == "A" || sol5 == "E" || sol5 == "I" || sol5 == "O" || sol5 == "U")
                {

                    suma8 = suma8 + 1;
                }
            }
            Console.WriteLine();
            int[] matrizDecontadores = new int[] { suma1, suma2, suma3, suma4, suma5, suma6, suma7, suma8 };

            Console.WriteLine("  Numero de cambios totales realizados: " + matrizDecontadores[0]);
            Console.WriteLine("  Numero de vocales en la matris:  " + matrizDecontadores[1]);
            Console.WriteLine("  Numero de simbolos en la matris:   " + matrizDecontadores[2]);
            Console.WriteLine("  Cantidad de " + "F" + " en la matris:  " + matrizDecontadores[3]);
            Console.WriteLine("  Cantidad de vocales en la columna 1 de la matris:  " + matrizDecontadores[4]);
            Console.WriteLine("  Cantidad de vocales en la columna 2 de la matris:  " + matrizDecontadores[5]);
            Console.WriteLine("  Cantidad de vocales en la columna 3 de la matris:  " + matrizDecontadores[6]);
            Console.WriteLine("  Cantidad de vocales en la columna 14 de la matris:  " + matrizDecontadores[7]);

        }
    }
}

