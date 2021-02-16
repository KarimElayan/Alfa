using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Ejercicio7Examen
    {
        //NO LO PUDE RESOLVER
        int Notificador = 0;
        public void Extra(int[,] Matriz)
        {   
            for (int x=0; x < Matriz.Length;x++)
            {
                if (Matriz[x, x] == 1)
                {
                    for (int y=x; y < (x+2); y++)
                    {
                        Matriz[y, y] = 1;
                    }
                    for (int y = x+3; y > x; y--)
                    {
                        Matriz[y, y] = 1;
                    }

                }
            }
            for (int x=0; x < Matriz.Length; x++)
            {
                int z=Matriz[x, x];
                Console.WriteLine(z);
                if (x > 3)
                {
                    Console.WriteLine();
                }
            }
                

        }
    }
}
