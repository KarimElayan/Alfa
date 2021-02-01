using System;

namespace ElRecopilado.Tarea
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] matrizcurp = new string[18];
            String Letra, Letra1, Letra2, Letra3, NewTexto;
            int numero, numero1, numero2, numero3, numero4, numero5;
            byte opc, opc2, opc3, opc4, opc5, opc6, opc7, opc8, opc9, opc10, opc11, opc12;
            string num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15, num16, num17, num18, num19, num20, num21,
                num22, num23, num24, num25, num26, num27, num28, num29, num30, num31, num32, num33;
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("                Forma de generar la curp");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Ingrese la Letra inicial de su primer apellido (Paterno):");
            matrizcurp[0] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la vocal de tu segundo apellido (Paterno):");
            matrizcurp[1] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la Primera Letra de tu apellido (Materno):");
            matrizcurp[2] = Console.ReadLine();
            Console.WriteLine("Ingrese la Primera letra de su Nombre:");
            matrizcurp[3] = Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine("        **************************************************         ");
            Console.WriteLine("        En esta parte iran los datos del año de nacimiento         ");
            Console.WriteLine("        **************************************************         ");
            Console.WriteLine("Si su año es 1999:");
            Console.WriteLine("Use los ultimos dos digitos 99 y coloquelos de manera individual");

            Console.WriteLine("Ingrese su año de Nacimiento (primer digito):");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero < -1 || numero > 10)
            {
                Console.WriteLine("Introdujiste un valor diferente");
                Console.WriteLine("Vuelve a introducir el valor:");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            Letra = numero.ToString();
            matrizcurp[4] = Letra;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ingrese su año de Nacimiento(segundo digito):");
            numero1 = Convert.ToInt32(Console.ReadLine());
            while (numero1 < -1 || numero1 > 10)
            {
                Console.WriteLine("Introdujiste un valor diferente");
                Console.WriteLine("Vuelve a introducir el valor:");
                numero1 = Convert.ToInt32(Console.ReadLine());
            }
            Letra1 = numero1.ToString();
            matrizcurp[5] = Letra1;
            Console.WriteLine();
            Console.WriteLine("En esta Parte sera la de su Mes de nacimiento :");
            Console.WriteLine();
            Console.WriteLine("Escribe en que mes naciste  con el digito numero correspondiente:");
            Console.WriteLine("01.- Enero");
            Console.WriteLine("2.- Febrero");
            Console.WriteLine("3.- Marzo");
            Console.WriteLine("4.- Abril");
            Console.WriteLine("5.- Mayo");
            Console.WriteLine("6.- Junio");
            Console.WriteLine("7.- Julio");
            Console.WriteLine("8.- Agosto");
            Console.WriteLine("9.- Septiembre");
            Console.WriteLine("10.- Octubre");
            Console.WriteLine("11.- Noviembre");
            Console.WriteLine("12.- Diciembre");
            Console.WriteLine("En que mes naciste:");
            opc = Convert.ToByte(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    opc = 1;
                    num1 = opc.ToString();
                    matrizcurp[7] = num1; 
                    break;

                case 2:
                    opc2 = 2;
                    num2 = opc2.ToString();
                    matrizcurp[7] = num2;
                    break;

                case 3:
                    opc3 = 3;
                    num3 = opc3.ToString();
                    matrizcurp[7] = num3;
                    break;

                case 4:
                    opc4 = 4;
                    num4 = opc4.ToString();
                    matrizcurp[7] = num4;
                    break;

                case 5:
                    opc5 = 5;
                    num5 = opc5.ToString();
                    matrizcurp[7] = num5;
                    break;

                case 6:
                    opc6 = 6;
                    num6 = opc6.ToString();
                    matrizcurp[7] = num6;
                    break;

                case 7:
                    opc7 = 7;
                    num7 = opc7.ToString();
                    matrizcurp[7] = num7;
                    break;

                case 8:
                    opc8 = 8;
                    num8 = opc8.ToString();
                    matrizcurp[7] = num8;
                    break;

                case 9:
                    opc9 = 9;
                    num9 = opc9.ToString();
                    matrizcurp[7] = num9;
                    break;

                case 10:
                    opc10 = 1;
                    num10 = opc10.ToString();
                    matrizcurp[6] = num10;
                    break;

                case 11:
                    opc11 = 1;
                    num11 = opc11.ToString();
                    matrizcurp[6] = num11;
                    matrizcurp[7] = num11;
                    break;

                case 12:
                    opc12 = 1;
                    num12 = opc12.ToString();
                    matrizcurp[6] = num12;
                    opc12 = 2;
                    num12 = opc12.ToString();
                    matrizcurp[7] = num12;
                    break;

                default:
                    Console.WriteLine("En que mes naciste:");
                    opc = Convert.ToByte(Console.ReadLine());
                    break;
            }
            Console.WriteLine("Ingrese su dia de Nacimiento(primer digito):");
            numero2 = Convert.ToInt32(Console.ReadLine());
            while (numero2 < -1 || numero2 > 4)
            {
                Console.WriteLine("Introdujiste un valor diferente");
                Console.WriteLine("Vuelve a introducir el valor:");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
            Letra2 = numero2.ToString();
            matrizcurp[8] = Letra2;
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Ingrese su dia de Nacimiento(segundo digito):");
            numero3 = Convert.ToInt32(Console.ReadLine());
            while (numero3 < -1 || numero3 > 10)
            {
                Console.WriteLine("Introdujiste un valor diferente");
                Console.WriteLine("Vuelve a introducir el valor:");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
            Letra2 = numero3.ToString();
            matrizcurp[9] = Letra2;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cual es tu Genero: (Hombre = H o Mujer = M");
            matrizcurp[10] = Console.ReadLine();             
            Console.WriteLine();

            
            Console.WriteLine(" 1.- AGUASCALIENTES, 2.- BAJA CALIFORNIA, 3.- BAJA CALIFORNIA SUR, 4.- CAMPECHE, 5.- COAHUILA, " +
                                          "6.- COLIMA, 7.- CHIAPAS, 8.- CHIHUAHUA, 9.- DISTRITO FEDERAL, 10.- DURANGO, 11.- GUANAJUATO" +
                                          "12.- GUERRERO, 13.- HIDALGO, 14.- JALISCO,  15.- MEXICO, 16.-  MICHOACAN,  17 .- MORELOS, 18.- NAYARIT," +
                                          "19.- NUEVO LEON, 20.- OAXACA, 21.- PUEBLA, 22.- QUERETARO, 23.- QUINTANA ROO, 24.- SAN LUIS POTOSI, " +
                                          "25.- SINALOA, 26.- SONORA, 27.- QUINTANA ROO, 28.- TABASCO, 29.- TAMAULIPAS, 30.- TLAXCALA, 31.- VERACRUZ, " +
                                          "32.- YUATAN, 33.- ZACATECAS");
            Console.WriteLine("En que mes naciste:");
            opc = Convert.ToByte(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    opc = 1;
                    num1 = opc.ToString();
                    NewTexto = num1.Replace(num1, "A");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num1.Replace(num1, "s");
                    matrizcurp[12] = NewTexto;
                    break;
                case 2:
                    opc = 2;
                    num2 = opc.ToString();
                    NewTexto = num2.Replace(num2, "B");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num2.Replace(num2, "C");
                    matrizcurp[12] = NewTexto;
                    break;
                case 3:
                    opc = 3;
                    num3 = opc.ToString();
                    NewTexto = num3.Replace(num3, "B");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num3.Replace(num3, "S");
                    matrizcurp[12] = NewTexto;
                    break;
                case 4:
                    opc = 4;
                    num4 = opc.ToString();
                    NewTexto = num4.Replace(num4, "C");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num4.Replace(num4, "C");
                    matrizcurp[12] = NewTexto;
                    break;
                case 5:
                    opc = 5;
                    num5 = opc.ToString();
                    NewTexto = num5.Replace(num5, "C");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num5.Replace(num5, "L");
                    matrizcurp[12] = NewTexto;
                    break;
                case 6:
                    opc = 6;
                    num6 = opc.ToString();
                    NewTexto = num6.Replace(num6, "C");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num6.Replace(num6, "M");
                    matrizcurp[12] = NewTexto;
                    break;
                case 7:
                    opc = 7;
                    num7 = opc.ToString();
                    NewTexto = num7.Replace(num7, "C");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num7.Replace(num7, "S");
                    matrizcurp[12] = NewTexto;
                    break;
                case 8:
                    opc = 8;
                    num8 = opc.ToString();
                    NewTexto = num8.Replace(num8, "C");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num8.Replace(num8, "H");
                    matrizcurp[12] = NewTexto;
                    break;
                case 9:
                    opc = 9;
                    num9 = opc.ToString();
                    NewTexto = num9.Replace(num9, "C");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num9.Replace(num9, "C");
                    matrizcurp[12] = NewTexto;
                    break;
                case 10:
                    opc = 10;
                    num10 = opc.ToString();
                    NewTexto = num10.Replace(num10, "D");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num10.Replace(num10, "F");
                    matrizcurp[12] = NewTexto;
                    break;
                case 11:
                    opc = 11;
                    num11 = opc.ToString();
                    NewTexto = num11.Replace(num11, "G");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num11.Replace(num11, "T");
                    matrizcurp[12] = NewTexto;
                    break;
                case 12:
                    opc = 12;
                    num12 = opc.ToString();
                    NewTexto = num12.Replace(num12, "G");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num12.Replace(num12, "R");
                    matrizcurp[12] = NewTexto;
                    break;
                case 13:
                    opc = 13;
                    num13 = opc.ToString();
                    NewTexto = num13.Replace(num13, "H");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num13.Replace(num13, "G");
                    matrizcurp[12] = NewTexto;
                    break;
                case 14:
                    opc = 14;
                    num14 = opc.ToString();
                    NewTexto = num14.Replace(num14, "J");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num14.Replace(num14, "C");
                    matrizcurp[12] = NewTexto;
                    break;
                case 15:
                    opc = 15;
                    num15 = opc.ToString();
                    NewTexto = num15.Replace(num15, "M");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num15.Replace(num15, "C");
                    matrizcurp[12] = NewTexto;
                    break;
                case 16:
                    opc = 16;
                    num16 = opc.ToString();
                    NewTexto = num16.Replace(num16, "M");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num16.Replace(num16, "N");
                    matrizcurp[12] = NewTexto;
                    break;
                case 17:
                    opc = 17;
                    num17 = opc.ToString();
                    NewTexto = num17.Replace(num17, "M");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num17.Replace(num17, "S");
                    matrizcurp[12] = NewTexto;
                    break;
                case 18:
                    opc = 18;
                    num18 = opc.ToString();
                    NewTexto = num18.Replace(num18, "N");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num18.Replace(num18, "T");
                    matrizcurp[12] = NewTexto;
                    break;
                case 19:
                    opc = 19;
                    num19 = opc.ToString();
                    NewTexto = num19.Replace(num19, "N");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num19.Replace(num19, "L");
                    matrizcurp[12] = NewTexto;
                    break;
                case 20:
                    opc = 20;
                    num20 = opc.ToString();
                    NewTexto = num20.Replace(num20, "O");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num20.Replace(num20, "C");
                    matrizcurp[12] = NewTexto;
                    break;
                case 21:
                    opc = 21;
                    num21 = opc.ToString();
                    NewTexto = num21.Replace(num21, "P");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num21.Replace(num21, "L");
                    matrizcurp[12] = NewTexto;
                    break;
                case 22:
                    opc = 22;
                    num22 = opc.ToString();
                    NewTexto = num22.Replace(num22, "Q");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num22.Replace(num22, "T");
                    matrizcurp[12] = NewTexto;
                    break;
                case 23:
                    opc = 23;
                    num23 = opc.ToString();
                    NewTexto = num23.Replace(num23, "Q");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num23.Replace(num23, "R");
                    matrizcurp[12] = NewTexto;
                    break;
                case 24:
                    opc = 24;
                    num24 = opc.ToString();
                    NewTexto = num24.Replace(num24, "S");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num24.Replace(num24, "P");
                    matrizcurp[12] = NewTexto;
                    break;
                case 25:
                    opc = 25;
                    num25 = opc.ToString();
                    NewTexto = num25.Replace(num25, "S");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num25.Replace(num25, "L");
                    matrizcurp[12] = NewTexto;
                    break;
                case 26:
                    opc = 26;
                    num26 = opc.ToString();
                    NewTexto = num26.Replace(num26, "S");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num26.Replace(num26, "R");
                    matrizcurp[12] = NewTexto;
                    break;
                case 27:
                    opc = 27;
                    num27 = opc.ToString();
                    NewTexto = num27.Replace(num27, "S");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num27.Replace(num27, "R");
                    matrizcurp[12] = NewTexto;
                    break;
                case 28:
                    opc = 28;
                    num28 = opc.ToString();
                    NewTexto = num28.Replace(num28, "S");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num28.Replace(num28, "R");
                    matrizcurp[12] = NewTexto;
                    break;
                case 29:
                    opc = 29;
                    num29 = opc.ToString();
                    NewTexto = num29.Replace(num29, "T");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num29.Replace(num29, "S");
                    matrizcurp[12] = NewTexto;
                    break;
                case 30:
                    opc = 30;
                    num30 = opc.ToString();
                    NewTexto = num30.Replace(num30, "T");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num30.Replace(num30, "L");
                    matrizcurp[12] = NewTexto;
                    break;
                case 31:
                    opc = 31;
                    num31 = opc.ToString();
                    NewTexto = num31.Replace(num31, "V");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num31.Replace(num31, "Z");
                    matrizcurp[12] = NewTexto;
                    break;
                case 32:
                    opc = 32;
                    num32 = opc.ToString();
                    NewTexto = num32.Replace(num32, "Y");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num32.Replace(num32, "N");
                    matrizcurp[12] = NewTexto;
                    break;
                case 33:
                    opc = 33;
                    num33 = opc.ToString();
                    NewTexto = num33.Replace(num33, "Z");
                    matrizcurp[11] = NewTexto;
                    NewTexto = num33.Replace(num33, "S");
                    matrizcurp[12] = NewTexto;
                    break;
            }
            Console.WriteLine("Ingrese la primera consonante interna del primer apellido(paterno):");
            matrizcurp[13] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la primera consonante interna del segundo apellido(materno):");
            matrizcurp[14] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la primera consonante interna de su nombre");
            matrizcurp[15] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Si nacio antes del 31 de Diciembre de 1999 escriba una letra cualquiera, " +
                              "Si nacio a partir del 1 Enero del 2000; Escriba un numero");
            numero5 = Convert.ToInt32(Console.ReadLine());
            while (numero5 < -1 || numero5 > 10)
            {
                Letra3 = numero5.ToString();
                matrizcurp[16] = Letra3;
            }
            Letra3 = numero5.ToString();
            matrizcurp[16] = Letra3;
            Console.WriteLine();
            Console.WriteLine("Ingrese un digito numerico cualquiera:");
            numero4 = Convert.ToInt32(Console.ReadLine());
            while (numero4 < -1 || numero4 > 10)
            {
                Console.WriteLine("Introdujiste un valor diferente");
                Console.WriteLine("Vuelve a introducir el valor:");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
            Letra2 = numero4.ToString();
            matrizcurp[17] = Letra2;
            Console.WriteLine();
            Console.WriteLine("La curp generada fue:" + matrizcurp[0] + matrizcurp[1] + matrizcurp[3] + matrizcurp[4] + 
                                                        matrizcurp[5] + matrizcurp[6] + matrizcurp[7] + matrizcurp[8] + 
                                                        matrizcurp[9] + matrizcurp[10] + matrizcurp[11] + matrizcurp[12] +
                                                        matrizcurp[13] + matrizcurp[14] + matrizcurp[15] + matrizcurp[16]
                                                      + matrizcurp[17]);                      
        }
        
    }
}
