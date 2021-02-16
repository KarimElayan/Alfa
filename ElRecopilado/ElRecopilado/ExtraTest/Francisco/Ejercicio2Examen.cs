using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Ejercicio2Examen
    {
        //INICIO
        //Paso 1: Obtencion de valor
        //Paso 2: Guardar el valor ingresado
        //Paso 2: "BUCLE" ---> 1 hasta el valor ingresado       "PRINCIPAL"
        //           Valor ingresado se le restara un "1" por cada iteracion 
        //             1."BUCLE" Del numero 1 hasta el valor guardado
                           //Imprimirar espacios tantas veces itere el bucle
        //             2."BUCLE" Del numero 1 hata el valor generado por el bucle principal
        //                 //Imprimir "*" tantas veces itere el bucle
        //FIN
        public void Ejercicio2(int Parametro)
        {
            int Recorrido=Parametro;
            for (int x=1; x <= Parametro; x++)
            {
                Recorrido--;
                for (int z = 1; z <= Recorrido; z++)
                {
                    Console.Write(" ");
                }
                for (int y=1; y <= x; y++)
                {
                   Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
