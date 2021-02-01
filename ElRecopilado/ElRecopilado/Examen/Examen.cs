using ElRecopilado.EnClase;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.Examen
{
    public static class Examen
    {
        //PARTE 1
        public static List<int> IndexOfCapitals(string str)
        {
            List<int> PosicionesDeMayusculas = new List<int>();   //posicion de mayusculas
            List<bool> ListaDeverdadDeCaracteres = new List<bool>();
            foreach (char ObtencionDeCaracteres in str)
            {
                if (ObtencionDeCaracteres == 'A' || ObtencionDeCaracteres == 'B' || ObtencionDeCaracteres == 'C' ||
                    ObtencionDeCaracteres == 'D' || ObtencionDeCaracteres == 'E' || ObtencionDeCaracteres == 'F' ||
                    ObtencionDeCaracteres == 'G' || ObtencionDeCaracteres == 'H' || ObtencionDeCaracteres == 'I' ||
                    ObtencionDeCaracteres == 'J' || ObtencionDeCaracteres == 'K' || ObtencionDeCaracteres == 'L' ||
                    ObtencionDeCaracteres == 'M' || ObtencionDeCaracteres == 'N' || ObtencionDeCaracteres == 'Ñ' ||
                    ObtencionDeCaracteres == 'O' || ObtencionDeCaracteres == 'P' || ObtencionDeCaracteres == 'Q' ||
                    ObtencionDeCaracteres == 'R' || ObtencionDeCaracteres == 'S' || ObtencionDeCaracteres == 'T' ||
                   ObtencionDeCaracteres == 'U' || ObtencionDeCaracteres == 'V' || ObtencionDeCaracteres == 'W' ||
                    ObtencionDeCaracteres == 'X' || ObtencionDeCaracteres == 'Y' || ObtencionDeCaracteres == 'Z')
                {
                    ListaDeverdadDeCaracteres.Add(true);
                }
                else
                {
                    ListaDeverdadDeCaracteres.Add(false);
                }
            }
            for (int y = 0; y < ListaDeverdadDeCaracteres.Count; y++)
            {
                if (ListaDeverdadDeCaracteres[y] == true)
                {
                    PosicionesDeMayusculas.Add(y);
                }
            }

            // return new List<int>();
            return PosicionesDeMayusculas;
        }
        // PARTE 2
        public static List<int> PrimeSerieAlfa(int n)
        {
            List<int> ListaDeNumeros = new List<int>();
            int valorAgregado = 1;
            ListaDeNumeros.Add(valorAgregado);
            int valorAgregado2 = 1;
            ListaDeNumeros.Add(valorAgregado2);
            int ValorDeAyuda = 2;
            int ValorDeAyuda2 = 3;
            int Suma;

            for (int x = 2; x < n; x++)
            {
                if (x == 2)
                {
                    ListaDeNumeros.Add(x);
                }
                if (x == 3)
                {
                    ListaDeNumeros.Add(x);
                }
                if (x > 3)
                {
                    Suma = ValorDeAyuda + ValorDeAyuda2;
                    ListaDeNumeros.Add(Suma);
                    ValorDeAyuda = ValorDeAyuda2;
                    ValorDeAyuda2 = Suma;
                }
            }
            List<int> ListaDeNumerosPrimos = new List<int>();
            int Dibisible = 0;
            foreach (int barrido in ListaDeNumeros)
            {
                for (int x = 1; x <= barrido; x++)
                {
                    if (barrido % x == 0)
                    {
                        Dibisible++;
                    }
                    if (Dibisible > 2)
                    {
                        break;
                    }
                }
                if (Dibisible == 2)
                {
                    ListaDeNumerosPrimos.Add(barrido);
                }
                Dibisible = 0;
            }
            List<int> ConteoDeNumerosPrimos = new List<int>();
            int conteoDeNumerosPrimos = 0;
            foreach (int conteo in ListaDeNumerosPrimos)
            {
                conteoDeNumerosPrimos++;
            }
            ConteoDeNumerosPrimos.Add(conteoDeNumerosPrimos);
            return ConteoDeNumerosPrimos;
        }

        //PARTE 3
        public static string LetrasPorNumeros(string str)
        {
            //  List<int>
            string TextoModificado = "";
            foreach (char ObtencionDeCaracteres in str)
            {
                if (ObtencionDeCaracteres == 'a')
                {
                    char CambioDeA = '4';
                    TextoModificado += CambioDeA.ToString();
                }
                if (ObtencionDeCaracteres == 'o')
                {
                    char CambioDeo = '0';
                    TextoModificado += CambioDeo.ToString();
                }
                if (ObtencionDeCaracteres == 'i')
                {
                    char CambioDei = '1';
                    TextoModificado += CambioDei.ToString();
                }
                if (ObtencionDeCaracteres == 's')
                {
                    char CambioDes = '$';
                    TextoModificado += CambioDes.ToString();
                }
                if (ObtencionDeCaracteres == 't')
                {
                    char CambioDet = '#';
                    TextoModificado += CambioDet.ToString();
                }
                else if (ObtencionDeCaracteres != 'a' & ObtencionDeCaracteres != 'o' & ObtencionDeCaracteres != 'i' & ObtencionDeCaracteres != 's' & ObtencionDeCaracteres != 't')
                {
                    TextoModificado += ObtencionDeCaracteres.ToString();

                }
            }
            return TextoModificado;
        }

        //PARTE 4
        public static string Cifrar(string str, int desp)
        {
            int letras = str.Length;
            int t;
            char caracter = ',';
            string salida = "";
            for (int x = 0; x < letras; x++)
            {
                t = (int)str[x];

                caracter = (char)(t + desp);
                salida += caracter;
            }
            return salida;
        }
        public static string Descifrar(string str, int desp)
        {
            int letras = str.Length;
            int t;
            char caracter = ',';
            string salida = "";
            for (int x = 0; x < letras; x++)
            {
                t = (int)str[x];
                caracter = (char)(t - desp);
                salida += caracter;
            }
            return salida;

        }

    }
}
