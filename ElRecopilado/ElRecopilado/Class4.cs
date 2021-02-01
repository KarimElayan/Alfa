using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Parte_4
{
    class Program
    {
        //PARTE 4
        public static string Cifrar(string str, int desp)
        {
            return "";
        }
        static string abc = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

        static void Main(string[] args)
        {

            String mensaje = "Cada vez que escucho hablar de ese gato, empiezo a sacar mi pistola [en relación a la Paradoja de Schrödinger]";

            //se cifra el mensaje
            string tmp = cifrar(mensaje, 10);


            Console.WriteLine("Mensaje cifrado: \"{0}\" \n\n", tmp);//se muestra en pantalla

            //se descifra el mensaje
            Console.WriteLine("Mensaje descifrado: \"{0}\" \n\n", descifrar(tmp, 10));

            //si se descifra con un desplazamiento diferente al que se uso para cifrar
            //el mensaje sera el equivocado
            Console.WriteLine("Mensaje descifrado con desplazamiento equivocado:\n \"{0}\"", descifrar(tmp, 7));

            Console.ReadKey();
        }


        static string cifrar(string mensaje, int desplazamiento)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posCaracter = getPosABC(mensaje[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + desplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        }
                        //concatena al mensaje cifrado
                        cifrado += abc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        cifrado += mensaje[i];
                    }
                }

            }
            return cifrado;
        }

        /* 
* El descifrado cesar es el procedimiento inverso al cifrado
*/
        static string descifrar(string mensaje, int desplazamiento)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posCaracter = getPosABC(mensaje[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - desplazamiento;
                        while (pos < 0)
                        {
                            pos = pos + abc.Length;
                        }
                        cifrado += abc[pos];
                    }
                    else
                    {
                        cifrado += mensaje[i];
                    }
                }

            }
            return cifrado;
        }

        /* obtiene la posicion del caracter pasado como parametro 
 * en la variable abc que es nuestro abecedario de cifrado/descifrado
 */
        static int getPosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
