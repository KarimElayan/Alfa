using System;

using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    //INICIO
    //Paso 1: Ingreso de datos "valor flotante"
    //Paso 2: Recorrer cada elemento que se encuentre en el valor obtenido 23.32 ----> 2-3-.-3-2
                   //Guardar los valores recorridos (ValoresDeSuma)
                   //SI SE ENCUENTRA "."  ---->Detener el flujo anterior, Obtener la posicion y sumarle un "1" (Posicion)
                           //Recorrer los elementos sobrantes empezando desde Posicion 
                               //Guardar los valores recorridos (ValoresDeMultiplicacion)
    //Paso 3: Sumar todos los valores guardados en (ValoresDeSuma)  "GUARDAR LO OBTENIDO (Suma)"
    //Paso 4: Multiplicar uno por uno los valores obtenidos de (ValoresDeMultiplicacion)   "GUARDAR LO OBTENIDO (Multiplicacion)"
    //Paso 5: Multiplicar la Suma por Multiplicacion (Guardar lo obtenido)
    //Paso 6: Retornar lo obtenido
    //FIN

    

    class Ejercicio3Examen
    {
        public float Ejercicio3(float Valor)
        {
            string FlotanteAcadena = Valor.ToString();
            string DigitosASumar="";
            string DigitosAmultiplicar = "";          //el valor retornado varia por que la variable de tipo float se redondea

            float SumaDeNumeros=0;
            float SumaMultiplicandoceConDecimales = 1;

            for (int x=0; x < FlotanteAcadena.Length; x++)      
            {
                if (FlotanteAcadena[x] == ',')
                {
                    int PosicionDeInicio = x + 1;
                    for (int y= PosicionDeInicio ; y < FlotanteAcadena.Length; y++)
                    {
                        DigitosAmultiplicar = DigitosAmultiplicar + FlotanteAcadena[y];
                    }
                    break;
                }
                DigitosASumar = DigitosASumar + FlotanteAcadena[x];
            }
            //Suma de digitos 
            for (int x=0; x < DigitosASumar.Length;x++ )
            {
                char c = DigitosASumar[x];
                float CaracterAflotante = c - '0';    //Caracter se convierte a float
                SumaDeNumeros = SumaDeNumeros + CaracterAflotante; 
            }
            //Suma multiplicandoce con los digitos sobrantes (decimales)
            for (int x = 0; x < DigitosAmultiplicar.Length; x++)
            {
                char c = DigitosAmultiplicar[x];
                float CaracterAflotante= c - '0';
                SumaMultiplicandoceConDecimales = SumaMultiplicandoceConDecimales * CaracterAflotante;
            }
            SumaMultiplicandoceConDecimales = SumaMultiplicandoceConDecimales * SumaDeNumeros;
           
           return SumaMultiplicandoceConDecimales;
        }
    }
}
