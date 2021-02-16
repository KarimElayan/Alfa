using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Ejercicio5Examen
    {
        //INICIO
        //Paso 1: Obtencion de datos --->      "PALABRA O FRASE"
        
        //Paso 3: Recorrer cada elemento de la palabra o frase 
                  //Si se encuentra un caracter bacio eliminarlo 
                  //Almacenar los caracteres (CaracteresAlmacenados)
        //Paso 4: Recorrer de forma inverza los caracteres (CaracteresAlmacenados)
                  //Guardar los caracteres(CaracteresInversos)
        //Paso 5: Si (CaracteresAlmacenados) es igual a (CaracteresInversos)
                   //RETORNAR VERDADERO
        //Paso 6: Si no se cumple lo anterior RETORNAR FALSO
        //FIN
        public bool Ejercicio5(string CadenaDeCaracteres)
        {
            string CadenaNormal = "";
            string CadenaInvertida="";
            List<char> CaracteresDeString = new List<char>();
            string CadenaDeCaracteresEnMinusculas = CadenaDeCaracteres.ToLower();
            
            for (int x=0; x < CadenaDeCaracteres.Length; x++)
            {
                CaracteresDeString.Add(CadenaDeCaracteresEnMinusculas[x]);  
            }
            
            for (int x=0; x < CaracteresDeString.Count;x++)
            {
                 if (CaracteresDeString[x] == ' ')
                {
                    CaracteresDeString.Remove(' ');
                }
            }
            foreach (char x in CaracteresDeString)
            {
                CadenaNormal += x;
            }
            for (int x=(CaracteresDeString.Count-1); x > -1; x--)
            {
                CadenaInvertida += CaracteresDeString[x];
            }
            if (CadenaNormal== CadenaInvertida)
            {
                return true;
            }
            return false;
        }
    }
}
