using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
    //INICIO
    //Se tiene un tablero de 8x8 
    //Paso 1: Obtencion de datos.  POSICIONES...(FilReina1,ColumReina1,FilReina2,ColumReina2)
    //Paso 2: Si una posicion obtenida es menor o igual a "0" o mayor a 8 ----> Retornar FALSO
    //Paso 3: Si no sucede lo anterior ----> Continuar proceso
    //Paso 4: Contener la reina "1" como un valor ----> Reina 1="1"
    //Paso 5: Contener la reina "2" como otro valor ----> Reina 2="2"
    //Paso 6: ITERAR DEL NUMERO 1 HASTA EL 8 
               //Reina 1[Valor iterado,ColumReina1]  ---->Recorrera toda la vertical donde se encuentra la Reina 1
               //Si en el transcurso se encuentra un numero "2" ---->RETORNAR VERDADERO
    //Paso 7: ITERAR DEL NUMERO 1 HATA EL 8
               //Reina 1[FilReina1,Valor iterado]  ---->Recorrera toda la orizontal donde se encuentra la Reina 1
               //Si en el transcurso se encuentra un numero "2" ---->RETORNAR VERDADERO
    //Tomar las posiciones de la reina 1 ----> x=FilReina1     y=ColumReina1
    //Paso 8: ITERAR DEL NUMERO 1 HASTA EL 8 ----> Solo para generar repeticiones
               //RECORRE UNA PARTE DE LA DIAGONAL IZQUIERDA DE LA REINA 1
               //Reina 1[x,y]    =      2 ----> Retornara un verdadero              
               //Por cada iteracion se le restara un 1 a las variables x,y
        //Si x o y llega a valer 0 terminar el proceso del iterador y continuar
    //Tomar las posiciones de la reina 1 ----> x=FilReina1     y=ColumReina1
    //Paso 9: ITERAR DEL NUMERO 1 HASTA EL 8 ----> Solo para generar repeticiones
               //RECORRE la PARTE SOBRANTE DE LA DIAGONAL IZQUIERDA DE LA REINA 1
               //Reina 1[x,y]    =      2 ----> Retornara un verdadero              
               //Por cada iteracion se le sumara un 1 a las variables x,y
        //Si x o y llega a valer 9 terminar el proceso del iterador y continuar
    //Paso 10: ITERAR DEL NUMERO 1 HASTA EL 8 ----> Solo para generar repeticiones
               //RECORRE PARTE DE LA DIAGONAL DERECHA DE LA REINA 1
               //Reina 1[x,y]    =      2 ----> Retornara un verdadero              
               //Por cada iteracion se le restara un 1 a la variable x y se le sumara un 1 a y
        //Si "x" llega a valer 0 o "y" vale 9 terminar el proceso del iterador y continuar
    //Paso 11: ITERAR DEL NUMERO 1 HASTA EL 8 ----> Solo para generar repeticiones
               //RECORRE EN SOBRANTE DE LA DIAGONAL DERECHA DE LA REINA 1
               //Reina 1[x,y]    =      2 ----> Retornara un verdadero              
               //Por cada iteracion se le sumara un 1 a la variable x y se le restara un 1 a y
        //Si "x" llega a valer 9 o "y" vale 0 terminar el proceso del iterador y continuar
    //Paso 12: Si no se cumplio lo anterior retornar falso
    //FIN



    class Ejercicio4Examen
    {
        public bool Ejercicio4(int FilaReina1, int ColumnaReina1, int FilaReina2, int ColumnaReina2)
        {
            bool VerdaderoFalso = false;
            if (FilaReina1 <= 0 || FilaReina1 >= 9 || ColumnaReina1 <= 0 || ColumnaReina1 >= 9 || FilaReina2 <= 0 || FilaReina2 >= 9 || ColumnaReina2 <= 0 || ColumnaReina2 >= 9)
            {
                return false;
            }

            int FilaDeReina1INCREMENTA = FilaReina1 - 1;
            int ColumnaDeReina1INCREMENTA = ColumnaReina1 - 1;
            int FilaDeReina1DECREMENTA = FilaReina1-1;
            int ColumnaDeReina1DECREMENTA = ColumnaReina1-1; 
            int[,] Tablero = new int[8,8];
            Tablero[FilaReina1-1, ColumnaReina1-1] = 1;         //1 representa a la reina
            Tablero[FilaReina2-1, ColumnaReina2-1] = 2;

            //verifica en forma vertical y orizontal      SE TOMO COMO REFERENCIA LA REINA 1
            for (int x=0; x < 8; x++)
            {
                if (Tablero[x,ColumnaReina1-1]==2)  //VERTICAL
                {
                    return VerdaderoFalso = true;
                }
                if (Tablero[FilaReina1 - 1, x]==2)           //HORIZONTAL
                {
                    return VerdaderoFalso = true;
                }
            }

            // SE TOMO COMO REFERENCIA LA REINA 1

            //                                DIAGONAL IZQUIERDA
            for (int x=0; x < 8; x++)    //SOLO SE CONCIDERO PARA ITERAR Y PODER IR COMPARANDO LAS DIAGONALES 
            {
                //Parte de diagonal izquierda
                 if (Tablero[FilaDeReina1DECREMENTA, ColumnaDeReina1DECREMENTA] == 2)
                 {
                    return VerdaderoFalso = true;
                 }
                 FilaDeReina1DECREMENTA--;
                 ColumnaDeReina1DECREMENTA--;
               
                if (FilaDeReina1DECREMENTA == -1 || ColumnaDeReina1DECREMENTA == -1)   
                {
                    break;
                }
            }
            for (int x = 0; x < 8; x++)
            {
                //Terminacion de diagonal izquierda
                if (Tablero[FilaDeReina1INCREMENTA, ColumnaDeReina1INCREMENTA] == 2)
                {
                    return VerdaderoFalso = true;
                }
                FilaDeReina1INCREMENTA++;
                ColumnaDeReina1INCREMENTA++;
                if (FilaDeReina1INCREMENTA == 8 || ColumnaDeReina1INCREMENTA == 8)
                {
                    break;
                }
            }
            
            //Estas variables vuelven a retomar su valor 
            FilaDeReina1INCREMENTA = FilaReina1 - 1;
            ColumnaDeReina1INCREMENTA = ColumnaReina1 - 1;
            FilaDeReina1DECREMENTA = FilaReina1 - 1;
            ColumnaDeReina1DECREMENTA = ColumnaReina1 - 1;
            
            //                  DIAGONAL DERECHA
            for (int x=0; x < 8; x++)
            {
                //Parte de la diagonal derecha
                if (Tablero[FilaDeReina1DECREMENTA, ColumnaDeReina1INCREMENTA] == 2)
                {

                    return VerdaderoFalso = true;
                }
                FilaDeReina1DECREMENTA--;
                ColumnaDeReina1INCREMENTA++;
                if (FilaDeReina1DECREMENTA == -1 || ColumnaDeReina1INCREMENTA == 8)
                {
                    break;
                }
            }
            for (int x=0; x < 8; x++)
            {
                //Terminacion de diagonal derecha
                if (Tablero[FilaDeReina1INCREMENTA, ColumnaDeReina1DECREMENTA] == 2)
                {
                    return VerdaderoFalso = true;
                }
                FilaDeReina1INCREMENTA++;
                ColumnaDeReina1DECREMENTA--;
                if (ColumnaDeReina1DECREMENTA == -1 || FilaDeReina1INCREMENTA == 8)
                {
                    break;
                }
            }


            return VerdaderoFalso;
        }
    }
}
