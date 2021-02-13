using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.ExtraTest.Francisco
{
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
                if (Tablero[x,ColumnaReina1-1]==2)
                {
                    return VerdaderoFalso = true;
                }
                if (Tablero[FilaReina1 - 1, x]==2)
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
