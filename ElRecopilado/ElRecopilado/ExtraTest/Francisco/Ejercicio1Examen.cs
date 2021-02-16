using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    //INICIO
    //Paso 1: Obtencion de valores(por medio de arreglo)
    //Paso 2: Si la longitud del arreglo es mayor que 100 retornara falso
    //Paso 3: Si la longitud es menor o igual a 100. PROSEGUIR!
    //Paso 4: Verificar cada elemento del contenedor de valores (arreglo)
            //1.Si un elemento es igual a "7" ---> Señalar que es verdadero (dentro de una variable)
            //2.Seguir verificando cada valor comenzando desde la posicion que se encontro el numero 7 
                   //Si un valor es diferente a "7"  ---> Terminar el proceso y guardar la posicion 
    //Paso 5: Verificar los valores sobrantes comenzando desde la posicion guardada
            //1.Si un elemento es igual a "7" ---> Señalar que es falso (dentro de la variable)
    //Paso 6: Si no se cumplio lo anterior ---> Señalar que es falso (dentro de la variable)
    //Paso 6: Retornar la variable
    //FIN

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
