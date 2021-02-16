using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Ejercicio6Examen
    {
        //INICIO
        //Paso 1: Obtener los valores (ARREGLO)
        //Paso 2: Recorrer cada elemento del arreglo ---->  1-2-3-4-5-6-7
              //Guardar el elemento obtenido (ValorObtenido)
                //Si (ValorObtenido) es mayor que (ValorObtenido mas una posicion)
                   //DEAYUDA=ValorObtenido
                   // ValorObtenido = ValorObtenido mas una posicion  ----> Hacer el cambio en la posicio del arreglo
                   //ValorObtenido mas una posicion = DEAYUDA  ----> Hacer el cambio en la posicio del arreglo
        //Guardar el ultimo valor del arreglo (ULTIMOVALOR)
        //Paso 3: Recorrer cada elemento del arreglo ya actualizado ---->  1-2-3-4-5-6-7
              //Guardar el elemento obtenido (ValorObtenido)
                //Si (ValorObtenido) es mayor que (ValorObtenido mas una posicion)
                   //DEAYUDA=ValorObtenido
                   // ValorObtenido = ValorObtenido mas una posicion  ----> Hacer el cambio en la posicio del arreglo
                   //ValorObtenido mas una posicion = DEAYUDA  ----> Hacer el cambio en la posicio del arreglo
        //Guardar el penultimo valor del arreglo (PENULTIMOVALOR)
        //Paso 4: Recorrer cada elemento del arreglo ya actualizado de forma inverza
              //Si el (valor recorrido) es menor al (ValorRecorrido - 1)
              // DEAYUDA= (valor recorrido) 
              // (valor recorrido) = (ValorRecorrido - 1)   ----> Hacer el cambio en la posicio del arreglo
              // (ValorRecorrido - 1)  = DEAYUDA ----> Hacer el cambio en la posicio del arreglo
        //Guardar el antepenultimo valor del arreglo (ANTEPENULTIMO)
        //Paso 5: Retornar : (ULTIMOVALOR),(PENULTIMOVALOR),(ANTEPENULTIMO)

        public int[] Ejercicio6(int[] ArregloRecibido)
        {
            int[] ContenedorDeValores = new int[3];
            // verifica si se comple la condicion: longitud 1-20. Si no se comple retornara ceros
            if (ArregloRecibido.Length > 200)
            {
                ContenedorDeValores[0]= 0; ContenedorDeValores[1] = 0; ContenedorDeValores[2] = 0;
                return ContenedorDeValores;
            }
            //Obtencion del valor mas grande
            for (int x=0; x < ArregloRecibido.Length; x++)
            {
                if (x < (ArregloRecibido.Length-1))
                {
                    if (ArregloRecibido[x] > ArregloRecibido[x + 1])
                    {
                        int VariableDeAyuda = ArregloRecibido[x + 1];
                        ArregloRecibido[x + 1] = ArregloRecibido[x];
                        ArregloRecibido[x] = VariableDeAyuda;
                    }
                }
            }
            //Obtencion del penultimo valor mas grande
            for (int x = 0; x < ArregloRecibido.Length; x++)
            {
                if (x < (ArregloRecibido.Length - 1))
                {
                    if (ArregloRecibido[x] > ArregloRecibido[x + 1])
                    {
                        int VariableDeAyuda = ArregloRecibido[x + 1];
                        ArregloRecibido[x + 1] = ArregloRecibido[x];
                        ArregloRecibido[x] = VariableDeAyuda;
                    }
                }
            }
            // Obtencion del valor mas pequeño
            for (int x= (ArregloRecibido.Length - 1); x > -1; x--)
            {
                if (x > 0)
                {
                    if (ArregloRecibido[x] < ArregloRecibido[x - 1])
                    {
                        int VariableDeAyuda = ArregloRecibido[x - 1];
                        ArregloRecibido[x - 1] = ArregloRecibido[x];
                        ArregloRecibido[x] = VariableDeAyuda;
                    }
                }
            }
            ContenedorDeValores[0] = ArregloRecibido[ArregloRecibido.Length-1];
            ContenedorDeValores[1]= ArregloRecibido[ArregloRecibido.Length - 2];
            ContenedorDeValores[2] = ArregloRecibido[0];
            return ContenedorDeValores;
        }
    }
}
