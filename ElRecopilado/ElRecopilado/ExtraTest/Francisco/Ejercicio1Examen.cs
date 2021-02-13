using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Ejercicio1Examen
    {
        public bool Ejercicio1(int[] Arreglo)
        {
            int ValorDeContinuacion=0;
            bool VerdaderoOFalso = false;
            if (Arreglo.Length <= 100)
            {
                for (int x = 0; x < Arreglo.Length; x++)
                {
                    if (Arreglo[x] == 7)
                    {
                        VerdaderoOFalso = true;

                        for (int y = x; y < Arreglo.Length; y++)
                        {
                            if (Arreglo[y] != 7)
                            {
                                ValorDeContinuacion = y;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (ValorDeContinuacion != 0)
                {
                    for (int x = ValorDeContinuacion; x < Arreglo.Length; x++)
                    {
                        if (Arreglo[x] == 7)
                        {
                            VerdaderoOFalso = false;
                            break;
                        }
                    }
                }
            }
           return VerdaderoOFalso;
        }
    }
}
