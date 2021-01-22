using System;

namespace ElRecopilado.EnClase
{
    internal class SopaDeLetras
    {
        public void Execute()
        {
            Console.WriteLine("ARREGLOS");

            Console.WriteLine("      __        _______    _______    _______   _______   ___        ______    ________  ");
            Console.WriteLine("     /\"\"\\      /\"      \\  /\"      \\  /\"     \"| /\" _   \"| |\"  |      /    \" \\  /\"       ) ");
            Console.WriteLine("    /    \\    |:        ||:        |(: ______)(: ( \\___) ||  |     // ____  \\(:   \\___/  ");
            Console.WriteLine("   /' /\\  \\   |_____/   )|_____/   ) \\/    |   \\/ \\      |:  |    /  /    ) :)\\___  \\    ");
            Console.WriteLine("  //  __'  \\   //      /  //      /  // ___)_  //  \\ ___  \\  |___(: (____/ //  __/  \\\\   ");
            Console.WriteLine(" /   /  \\\\  \\ |:  __   \\ |:  __   \\ (:      \"|(:   _(  _|( \\_|:  \\\\        /  /\" \\   :)  ");
            Console.WriteLine("(___/    \\___)|__|  \\___)|__|  \\___) \\_______) \\_______)  \\_______)\\\"_____/  (_______/   ");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //ArregloSimple();
            Tarea();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private void ArregloSimple()
        {
            int[,] matrizDeNumeros;
            int[,,] cuboDeNumeros;
            int[,,,] noSeQueEsEsto;

            //Esto no funciona por que??
            //int[] arregloDeNumeros;
            //arregloDeNumeros[0] = 9;

            //Cual es la diff entre
            int[] arregloDeNumeros = new int[10];
            //y
            int[] arregloDeNumeros2 = new int[] { 1, 3, 5, 7, 9 };

            //for desde 0 a 4
            Console.WriteLine("CON For");
            for (int i = 0; i < arregloDeNumeros2.Length; i++)
            {
                Console.WriteLine("arregloDeNumeros2[" + i + "]: " + arregloDeNumeros2[i]);
            }

            //Console.WriteLine("SIN For");
            //Console.WriteLine("arregloDeNumeros2[0]: " + arregloDeNumeros2[0]);
            //Console.WriteLine("arregloDeNumeros2[1]: " + arregloDeNumeros2[1]);
            //Console.WriteLine("arregloDeNumeros2[2]: " + arregloDeNumeros2[2]);
            //Console.WriteLine("arregloDeNumeros2[3]: " + arregloDeNumeros2[3]);
            //Console.WriteLine("arregloDeNumeros2[4]: " + arregloDeNumeros2[4]);

            //Marca error por indice fuera de rango
            //Console.WriteLine("arregloDeNumeros2[5]: " + arregloDeNumeros2[5]);

            //declarar multiples arreglos unidimencionales es tedioso
            //int[] BatallaNavalFila1 = new int[] { 1, 1, 0, 1, 0, 0, 1, 1, 1, 1 };
            //int[] BatallaNavalFila2 = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 };

            int[,] BatallaNaval = new int[2, 10] { { 1, 1, 0, 1, 0, 1, 1, 1, 1, 1 },
                                                   { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }};

            Console.WriteLine("BatallaNaval[1,5]: " + BatallaNaval[1, 5]);
            Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, 0]);

            //buscar patron de problema

            //esto imprime la primera fila x=0 y  0>=y<=9
            Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, 0]);
            Console.WriteLine("BatallaNaval[0,1]: " + BatallaNaval[0, 1]);
            Console.WriteLine("BatallaNaval[0,2]: " + BatallaNaval[0, 2]);
            Console.WriteLine("BatallaNaval[0,3]: " + BatallaNaval[0, 3]);
            //Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, .]);
            //Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, .]);
            //Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, .]);
            Console.WriteLine("BatallaNaval[0,7]: " + BatallaNaval[0, 7]);
            Console.WriteLine("BatallaNaval[0,8]: " + BatallaNaval[0, 8]);
            Console.WriteLine("BatallaNaval[0,9]: " + BatallaNaval[0, 9]);

            //esto imprime la segunda fila x=1 y  0>=y<=9
            Console.WriteLine("BatallaNaval[1,0]: " + BatallaNaval[1, 0]);
            Console.WriteLine("BatallaNaval[1,1]: " + BatallaNaval[1, 1]);
            Console.WriteLine("BatallaNaval[1,2]: " + BatallaNaval[1, 2]);
            Console.WriteLine("BatallaNaval[1,3]: " + BatallaNaval[1, 3]);
            //Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, .]);
            //Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, .]);
            //Console.WriteLine("BatallaNaval[0,0]: " + BatallaNaval[0, .]);
            Console.WriteLine("BatallaNaval[1,7]: " + BatallaNaval[1, 7]);
            Console.WriteLine("BatallaNaval[1,8]: " + BatallaNaval[1, 8]);
            Console.WriteLine("BatallaNaval[1,9]: " + BatallaNaval[1, 9]);

            Console.WriteLine("-----------------------");
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.WriteLine("BatallaNaval[" + x + "," + y + "]: " + BatallaNaval[x, y]);
                }
                Console.WriteLine("=======");
            }

            //printArreglos(arregloDeNumeros2);

            //float[] calificaciones = 0.0f;

            noSeQueEsEsto = new int[2, 2, 2, 2];
        }

        private void printArreglos(int[] arr)
        {
            string cadena = "[";
            foreach (int item in arr)
            {
                cadena += (item + ", ");
            }
            cadena = cadena.Remove(cadena.Length - 2) + "]";
            Console.WriteLine(cadena);
        }

        public void Tarea()
        {
            string[,] matrizDeLetras = new string[,]
            {
                {"G","Q","Y","X","F","C","O","N","S","O","L","E","W","A"},
                {"B","Z","T","B","C","V","D","U","A","R","R","S","A","R"},
                {"P","X","U","N","F","Y","M","J","H","V","G","T","L","R"},
                {"X","Y","H","S","I","N","T","A","X","I","S","R","G","E"},
                {"R","N","H","J","Y","Y","Q","V","V","M","Q","I","O","G"},
                {"D","O","U","B","L","E","O","L","X","U","O","N","R","L"},
                {"A","T","R","D","F","M","O","F","H","D","K","G","I","O"},
                {"T","T","A","N","L","O","F","M","V","T","E","S","T","K"},
                {"D","C","K","C","O","I","S","W","T","H","K","C","M","O"},
                {"H","W","O","L","A","E","X","T","H","B","R","H","O","C"},
                {"I","N","T","A","T","L","Z","R","R","O","L","A","R","L"},
                {"S","K","Z","S","M","C","A","P","E","O","T","R","H","Z"},
                {"Q","X","F","S","P","O","C","S","I","L","S","J","F","O"},
                {"N","Q","I","P","Z","F","#","B","C","A","X","D","V","Q"}
            };

            Console.WriteLine("Matriz normal");
            for (int x = 0; x < 14; x++)
            {
                for (int y = 0; y < 14; y++)
                {
                    Console.Write(matrizDeLetras[x, y] + (
                            (y == 13) ? "" : ", "
                        )
                        );
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz inver");
            for (int x = 13; x >= 0; x--)
            {
                for (int y = 13; y > -1; y--)
                {
                    Console.Write(matrizDeLetras[x, y] + (
                            (y == 0) ? "" : ", "
                        )
                        );
                }
                Console.WriteLine();
            }

            //Console.WriteLine("Matriz normal");
            //printArreglos(matrizDeLetras);

            //Console.WriteLine("Matriz inversa");
            //printArreglosInverso(matrizDeLetras);

            int numeroDeCambios = 0;
            int numeroDeVocales = 0;
            int numeroDeSimbolos = 1;
            int numeroDeF = 0;
            int numeroDeVocalCol1 = 0;
            int numeroDeVocalCol2 = 0;
            int numeroDeVocalCol3 = 0;
            int numeroDeVocalCol4 = 0;
            int numeroDeVocalCol5 = 0;
            int numeroDeVocalCol6 = 0;
            int numeroDeVocalCol7 = 0;
            int numeroDeVocalCol8 = 0;
            int numeroDeVocalCol9 = 0;
            int numeroDeVocalCol10 = 0;
            int numeroDeVocalCol11 = 0;
            int numeroDeVocalCol12 = 0;
            int numeroDeVocalCol13 = 0;
            int numeroDeVocalCol14 = 0;

            if (matrizDeLetras[0, 0] == "A")
            {
                matrizDeLetras[0, 0] = "a";
                numeroDeCambios++;
                numeroDeVocales++;
            }
            if (matrizDeLetras[0, 0] == "E")
            {
                matrizDeLetras[0, 0] = "e";
            }
            if (matrizDeLetras[0, 0] == "I")
            {
                matrizDeLetras[0, 0] = "i";
            }
            if (matrizDeLetras[0, 0] == "O")
            {
                matrizDeLetras[0, 0] = "o";
            }
            if (matrizDeLetras[0, 0] == "U")
            {
                matrizDeLetras[0, 0] = "u";
            }

            if (matrizDeLetras[0, 0] == "B")
            {
                matrizDeLetras[0, 0] = "2";
                numeroDeCambios++;
            }

            for (int x = 0; x < matrizDeLetras.GetLength(0); x++)
            {
                for (int y = 0; y < matrizDeLetras.GetLength(1); y++)
                {
                    switch (y)
                    {
                        //case 0:
                        //    if (matrizDeLetras[x, y] == "A" ||
                        //        matrizDeLetras[x, y] == "E" ||
                        //        matrizDeLetras[x, y] == "I" ||
                        //        matrizDeLetras[x, y] == "O" ||
                        //        matrizDeLetras[x, y] == "U")
                        //    {
                        //        numeroDeVocalCol1++;
                        //    }
                        //    break;
                        case 0:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol1++;
                            }
                            break;

                        case 1:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol2++;
                            }
                            break;

                        case 2:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol3++;
                            }
                            break;

                        case 3:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol4++;
                            }
                            break;

                        case 4:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol5++;
                            }
                            break;

                        case 5:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol6++;
                            }
                            break;

                        case 6:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol7++;
                            }
                            break;

                        case 7:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol8++;
                            }
                            break;

                        case 8:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol9++;
                            }
                            break;

                        case 9:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol10++;
                            }
                            break;

                        case 10:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol11++;
                            }
                            break;

                        case 11:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol12++;
                            }
                            break;

                        case 12:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol13++;
                            }
                            break;

                        case 13:
                            if (isVocal(matrizDeLetras[x, y]))
                            {
                                numeroDeVocalCol14++;
                            }
                            break;

                        default:
                            break;
                    }

                    switch (matrizDeLetras[x, y])
                    {
                        case "A":
                        case "E":
                        case "I":
                        case "O":
                        case "U":
                            matrizDeLetras[x, y] = matrizDeLetras[x, y].ToLower();
                            numeroDeCambios++;
                            numeroDeVocales++;
                            break;

                        case "B":
                            matrizDeLetras[x, y] = "2";
                            numeroDeCambios++;
                            break;

                        case "C":
                        case "Z":
                            matrizDeLetras[x, y] = "%";
                            numeroDeCambios++;
                            numeroDeSimbolos++;
                            break;

                        case "F":
                            numeroDeF++;
                            break;

                        case "T":
                            matrizDeLetras[x, y] = "5";
                            numeroDeCambios++;
                            break;

                        default:
                            break;
                    }
                }
            }

            printArreglos(matrizDeLetras);
            int[] resultados = new int[] { numeroDeCambios,
                                            numeroDeVocales,
                                            numeroDeSimbolos,
                                            numeroDeF,
                                            numeroDeVocalCol1,
                                            numeroDeVocalCol2,
                                            numeroDeVocalCol3,
                                            numeroDeVocalCol4,
                                            numeroDeVocalCol5,
                                            numeroDeVocalCol6,
                                            numeroDeVocalCol7,
                                            numeroDeVocalCol8,
                                            numeroDeVocalCol9,
                                            numeroDeVocalCol10,
                                            numeroDeVocalCol11,
                                            numeroDeVocalCol12,
                                            numeroDeVocalCol13,
                                            numeroDeVocalCol14};

            Console.WriteLine("Resultados");
            Console.Write("| ");
            foreach (int item in resultados)
            {
                Console.Write(item + " | ");
            }
        }

        private bool isVocal(string letra)
        {
            letra = letra.ToUpper();
            return (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U");
        }

        private void printArreglos(string[,] arr)
        {
            string cadena = "[\r\n";

            for (int x = 0; x < arr.GetLength(0); x++)
            {
                cadena += "  ";
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    cadena += (arr[x, y] + ", ");
                }
                cadena = cadena.Remove(cadena.Length - 2);
                cadena += "\r\n";
            }
            cadena = cadena.Remove(cadena.Length - 2) + "]";
            Console.WriteLine(cadena);
        }

        private void printArreglosInverso(string[,] arr)
        {
            string cadena = "[\r\n";

            for (int x = arr.GetLength(0) - 1; x >= 0; x--)
            {
                cadena += "  ";
                for (int y = arr.GetLength(1) - 1; y >= 0; y--)
                {
                    cadena += (arr[x, y] + ", ");
                }
                cadena = cadena.Remove(cadena.Length - 2);
                cadena += "\r\n";
            }
            cadena = cadena.Remove(cadena.Length - 2) + "]";
            Console.WriteLine(cadena);
        }
    }
}