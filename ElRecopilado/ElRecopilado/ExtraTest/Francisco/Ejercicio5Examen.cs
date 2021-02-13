using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    class Ejercicio5Examen
    {
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
