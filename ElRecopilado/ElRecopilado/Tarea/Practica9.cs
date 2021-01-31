using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ElRecopilado.Tarea
{
    class Practica9
    {
        public string DatosDeIngreso(string Apaterno, string Amaterno, string Nombre, string Año, string Mes, string Dia, bool sexo, int Entidad)
        {
            string Curp = "";
            List<Char> CarateresDeApellido = new List<Char>(); //lista de caracteres de apellido paterno
            List<Char> CarateresDeApellidoMaterno = new List<Char>(); //lista de caracteres de apellido materno
            List<Char> CarateresNombreDeLaPersona = new List<Char>();  //lista de caracteres nombre
            List<Char> CarateresAño = new List<Char>();  //lista de caracteres año
            List<Char> CarateresMes = new List<Char>();  //lista de caracteres mes
            List<Char> CarateresDia = new List<Char>();  //lista de caracteres dia
            foreach (char w in Dia)
            {
                CarateresDia.Add(w);
            }
            foreach (char g in Mes)
            {
                CarateresMes.Add(g);
            }
            foreach (char v in Año)
            {
                CarateresAño.Add(v);
            }
            foreach (char c in Nombre)
            {
                CarateresNombreDeLaPersona.Add(c);
            }
            foreach (char y in Amaterno)
            {
                CarateresDeApellidoMaterno.Add(y);
            }

            foreach (char x in Apaterno)
            {
                CarateresDeApellido.Add(x);
            }
            Curp += CarateresDeApellido[0]; //Primera letra de curp

            for (int x = 1; x < (CarateresDeApellido.Count - 1); x++)
            {
                if (CarateresDeApellido[x] == 'A' || CarateresDeApellido[x] == 'E' || CarateresDeApellido[x] == 'I' || CarateresDeApellido[x] == 'O' || CarateresDeApellido[x] == 'U')
                {
                    Curp += CarateresDeApellido[x];
                    break;
                }
            }
            Curp += CarateresDeApellidoMaterno[0];
            Curp += CarateresNombreDeLaPersona[0];
            for (int x = 2; x < CarateresAño.Count; x++)
            {
                Curp += CarateresAño[x];
            }
            for (int x = 0; x < CarateresMes.Count; x++)
            {
                Curp += CarateresMes[x];
            }
            for (int x = 0; x < CarateresDia.Count; x++)
            {
                Curp += CarateresDia[x];
            }
            if (sexo == true || sexo == false)
            {
                if (sexo == true)
                {
                    string Genero = "H";
                    Curp += Genero;
                }
                else
                {
                    string Genero = "M";
                    Curp += Genero;
                }
            }
            string EntidadDeLaPersona = "";
            if (Entidad == 1 || Entidad == 2 || Entidad == 3 || Entidad == 4 || Entidad == 5 || Entidad == 6 || Entidad == 7 || Entidad == 8 || Entidad == 9 || Entidad == 10 || Entidad == 11 || Entidad == 12 || Entidad == 13 || Entidad == 14 || Entidad == 15 || Entidad == 16 || Entidad == 17 || Entidad == 18 || Entidad == 19 || Entidad == 20 || Entidad == 21 || Entidad == 22 || Entidad == 23 || Entidad == 24 || Entidad == 25 || Entidad == 26 || Entidad == 27 || Entidad == 28 || Entidad == 29 || Entidad == 30 || Entidad == 31 || Entidad == 32 || Entidad == 33)
            {
                if (Entidad == 1)
                {
                    EntidadDeLaPersona = "AS";
                }
                if (Entidad == 2)
                {
                    EntidadDeLaPersona = "BS";
                }
                if (Entidad == 3)
                {
                    EntidadDeLaPersona = "BC";
                }
                if (Entidad == 4)
                {
                    EntidadDeLaPersona = "CC";
                }
                if (Entidad == 5)
                {
                    EntidadDeLaPersona = "CL";
                }
                if (Entidad == 6)
                {
                    EntidadDeLaPersona = "CM";
                }
                if (Entidad == 7)
                {
                    EntidadDeLaPersona = "CS";
                }
                if (Entidad == 8)
                {
                    EntidadDeLaPersona = "DF";
                }
                if (Entidad == 9)
                {
                    EntidadDeLaPersona = "CH";
                }
                if (Entidad == 10)
                {
                    EntidadDeLaPersona = "DG";
                }
                if (Entidad == 11)
                {
                    EntidadDeLaPersona = "GT";
                }
                if (Entidad == 12)
                {
                    EntidadDeLaPersona = "GR";
                }
                if (Entidad == 13)
                {
                    EntidadDeLaPersona = "HG";
                }
                if (Entidad == 14)
                {
                    EntidadDeLaPersona = "JC";
                }
                if (Entidad == 15)
                {
                    EntidadDeLaPersona = "MC";
                }
                if (Entidad == 16)
                {
                    EntidadDeLaPersona = "MN";
                }
                if (Entidad == 17)
                {
                    EntidadDeLaPersona = "MS";
                }
                if (Entidad == 18)
                {
                    EntidadDeLaPersona = "NT";
                }
                if (Entidad == 19)
                {
                    EntidadDeLaPersona = "NL";
                }
                if (Entidad == 20)
                {
                    EntidadDeLaPersona = "OC";
                }
                if (Entidad == 21)
                {
                    EntidadDeLaPersona = "PL";
                }
                if (Entidad == 22)
                {
                    EntidadDeLaPersona = "QT";
                }
                if (Entidad == 23)
                {
                    EntidadDeLaPersona = "QR";
                }
                if (Entidad == 24)
                {
                    EntidadDeLaPersona = "SP";
                }
                if (Entidad == 25)
                {
                    EntidadDeLaPersona = "SL";
                }
                if (Entidad == 26)
                {
                    EntidadDeLaPersona = "SR";
                }
                if (Entidad == 27)
                {
                    EntidadDeLaPersona = "TC";
                }

                if (Entidad == 28)
                {
                    EntidadDeLaPersona = "TS";
                }
                if (Entidad == 29)
                {
                    EntidadDeLaPersona = "TL";
                }
                if (Entidad == 30)
                {
                    EntidadDeLaPersona = "VZ";
                }
                if (Entidad == 31)
                {
                    EntidadDeLaPersona = "YN";
                }
                if (Entidad == 32)
                {
                    EntidadDeLaPersona = "ZS";
                }
                if (Entidad == 33)
                {
                    EntidadDeLaPersona = "NE";
                }
            }
            Curp += EntidadDeLaPersona;

            char Consonante1 = ' ';
            for (int s = 0; s < CarateresDeApellidoMaterno.Count; s++)
            {
                if (CarateresDeApellido[s] == 'B' || CarateresDeApellido[s] == 'C' || CarateresDeApellido[s] == 'D' || CarateresDeApellido[s] == 'F' || CarateresDeApellido[s] == 'G' || CarateresDeApellido[s] == 'H' || CarateresDeApellido[s] == 'J' || CarateresDeApellido[s] == 'K' || CarateresDeApellido[s] == 'L' || CarateresDeApellido[s] == 'M' || CarateresDeApellido[s] == 'N' || CarateresDeApellido[s] == 'P' || CarateresDeApellido[s] == 'Q' || CarateresDeApellido[s] == 'R' || CarateresDeApellido[s] == 'S' || CarateresDeApellido[s] == 'T' || CarateresDeApellido[s] == 'V' || CarateresDeApellido[s] == 'W' || CarateresDeApellido[s] == 'X' || CarateresDeApellido[s] == 'Y' || CarateresDeApellido[s] == 'Z')
                {
                    Consonante1 = CarateresDeApellido[s];
                    break;
                }
            }

            int suma = 0;
            for (int a = 0; a < CarateresDeApellido.Count; a++)
            {
                if (a == 0)
                {
                    if (CarateresDeApellido[a] == 'A' || CarateresDeApellido[a] == 'E' || CarateresDeApellido[a] == 'I' || CarateresDeApellido[a] == 'O' || CarateresDeApellido[a] == 'U')
                    {

                        Curp += Consonante1;
                        break;
                    }
                }
                if (CarateresDeApellido[a] == 'B' || CarateresDeApellido[a] == 'C' || CarateresDeApellido[a] == 'D' || CarateresDeApellido[a] == 'F' || CarateresDeApellido[a] == 'G' || CarateresDeApellido[a] == 'H' || CarateresDeApellido[a] == 'J' || CarateresDeApellido[a] == 'K' || CarateresDeApellido[a] == 'L' || CarateresDeApellido[a] == 'M' || CarateresDeApellido[a] == 'N' || CarateresDeApellido[a] == 'P' || CarateresDeApellido[a] == 'Q' || CarateresDeApellido[a] == 'R' || CarateresDeApellido[a] == 'S' || CarateresDeApellido[a] == 'T' || CarateresDeApellido[a] == 'V' || CarateresDeApellido[a] == 'W' || CarateresDeApellido[a] == 'X' || CarateresDeApellido[a] == 'Y' || CarateresDeApellido[a] == 'Z')
                {
                    suma++;
                    if (suma == 2)
                    {
                        Curp += CarateresDeApellido[a];
                        break;
                    }
                }

            }
            char Consonante = ' ';
            for (int s = 0; s < CarateresDeApellidoMaterno.Count; s++)
            {
                if (CarateresDeApellidoMaterno[s] == 'B' || CarateresDeApellidoMaterno[s] == 'C' || CarateresDeApellidoMaterno[s] == 'D' || CarateresDeApellidoMaterno[s] == 'F' || CarateresDeApellidoMaterno[s] == 'G' || CarateresDeApellidoMaterno[s] == 'H' || CarateresDeApellidoMaterno[s] == 'J' || CarateresDeApellidoMaterno[s] == 'K' || CarateresDeApellidoMaterno[s] == 'L' || CarateresDeApellidoMaterno[s] == 'M' || CarateresDeApellidoMaterno[s] == 'N' || CarateresDeApellidoMaterno[s] == 'P' || CarateresDeApellidoMaterno[s] == 'Q' || CarateresDeApellidoMaterno[s] == 'R' || CarateresDeApellidoMaterno[s] == 'S' || CarateresDeApellidoMaterno[s] == 'T' || CarateresDeApellidoMaterno[s] == 'V' || CarateresDeApellidoMaterno[s] == 'W' || CarateresDeApellidoMaterno[s] == 'X' || CarateresDeApellidoMaterno[s] == 'Y' || CarateresDeApellidoMaterno[s] == 'Z')
                {
                    Consonante = CarateresDeApellidoMaterno[s];
                    break;
                }
            }

            int suma1 = 0;
            for (int a = 0; a < CarateresDeApellidoMaterno.Count; a++)
            {
                if (a == 0)
                {
                    if (CarateresDeApellidoMaterno[a] == 'A' || CarateresDeApellidoMaterno[a] == 'E' || CarateresDeApellidoMaterno[a] == 'I' || CarateresDeApellidoMaterno[a] == 'O' || CarateresDeApellidoMaterno[a] == 'U')
                    {

                        Curp += Consonante;
                        break;
                    }
                }


                if (CarateresDeApellidoMaterno[a] == 'B' || CarateresDeApellidoMaterno[a] == 'C' || CarateresDeApellidoMaterno[a] == 'D' || CarateresDeApellidoMaterno[a] == 'F' || CarateresDeApellidoMaterno[a] == 'G' || CarateresDeApellidoMaterno[a] == 'H' || CarateresDeApellidoMaterno[a] == 'J' || CarateresDeApellidoMaterno[a] == 'K' || CarateresDeApellidoMaterno[a] == 'L' || CarateresDeApellidoMaterno[a] == 'M' || CarateresDeApellidoMaterno[a] == 'N' || CarateresDeApellidoMaterno[a] == 'P' || CarateresDeApellidoMaterno[a] == 'Q' || CarateresDeApellidoMaterno[a] == 'R' || CarateresDeApellidoMaterno[a] == 'S' || CarateresDeApellidoMaterno[a] == 'T' || CarateresDeApellidoMaterno[a] == 'V' || CarateresDeApellidoMaterno[a] == 'W' || CarateresDeApellidoMaterno[a] == 'X' || CarateresDeApellidoMaterno[a] == 'Y' || CarateresDeApellidoMaterno[a] == 'Z')
                {
                    suma1++;
                    if (suma1 == 2)
                    {
                        Curp += CarateresDeApellidoMaterno[a];
                        break;
                    }
                }

            }
            char Consonante3 = ' ';
            for (int s = 0; s < CarateresNombreDeLaPersona.Count; s++)
            {
                if (CarateresNombreDeLaPersona[s] == 'B' || CarateresNombreDeLaPersona[s] == 'C' || CarateresNombreDeLaPersona[s] == 'D' || CarateresNombreDeLaPersona[s] == 'F' || CarateresNombreDeLaPersona[s] == 'G' || CarateresNombreDeLaPersona[s] == 'H' || CarateresNombreDeLaPersona[s] == 'J' || CarateresNombreDeLaPersona[s] == 'K' || CarateresNombreDeLaPersona[s] == 'L' || CarateresNombreDeLaPersona[s] == 'M' || CarateresNombreDeLaPersona[s] == 'N' || CarateresNombreDeLaPersona[s] == 'P' || CarateresNombreDeLaPersona[s] == 'Q' || CarateresNombreDeLaPersona[s] == 'R' || CarateresNombreDeLaPersona[s] == 'S' || CarateresNombreDeLaPersona[s] == 'T' || CarateresNombreDeLaPersona[s] == 'V' || CarateresNombreDeLaPersona[s] == 'W' || CarateresNombreDeLaPersona[s] == 'X' || CarateresNombreDeLaPersona[s] == 'Y' || CarateresNombreDeLaPersona[s] == 'Z')
                {
                    Consonante3 = CarateresNombreDeLaPersona[s];
                    break;
                }
            }

            int suma2 = 0;
            for (int a = 0; a < CarateresNombreDeLaPersona.Count; a++)
            {
                if (a == 0)
                {
                    if (CarateresNombreDeLaPersona[a] == 'A' || CarateresNombreDeLaPersona[a] == 'E' || CarateresNombreDeLaPersona[a] == 'I' || CarateresNombreDeLaPersona[a] == 'O' || CarateresNombreDeLaPersona[a] == 'U')
                    {

                        Curp += Consonante3;
                        break;
                    }
                }


                if (CarateresNombreDeLaPersona[a] == 'B' || CarateresNombreDeLaPersona[a] == 'C' || CarateresNombreDeLaPersona[a] == 'D' || CarateresNombreDeLaPersona[a] == 'F' || CarateresNombreDeLaPersona[a] == 'G' || CarateresNombreDeLaPersona[a] == 'H' || CarateresNombreDeLaPersona[a] == 'J' || CarateresNombreDeLaPersona[a] == 'K' || CarateresNombreDeLaPersona[a] == 'L' || CarateresNombreDeLaPersona[a] == 'M' || CarateresNombreDeLaPersona[a] == 'N' || CarateresNombreDeLaPersona[a] == 'P' || CarateresNombreDeLaPersona[a] == 'Q' || CarateresNombreDeLaPersona[a] == 'R' || CarateresNombreDeLaPersona[a] == 'S' || CarateresNombreDeLaPersona[a] == 'T' || CarateresNombreDeLaPersona[a] == 'V' || CarateresNombreDeLaPersona[a] == 'W' || CarateresNombreDeLaPersona[a] == 'X' || CarateresNombreDeLaPersona[a] == 'Y' || CarateresNombreDeLaPersona[a] == 'Z')
                {
                    suma2++;
                    if (suma2 == 2)
                    {
                        Curp += CarateresNombreDeLaPersona[a];
                        break;
                    }
                }

            }



            return Curp;
        }
        public void IngresoDeDatos()
        {
            Practica9 Prueba = new Practica9();
            Console.WriteLine("Ingresa tu apellido paterno: ");
            string paterno1 = Console.ReadLine();
            string paterno = paterno1.ToUpper();
            Console.WriteLine("Ingresa tu apellido materno: ");
            string materno1 = Console.ReadLine();
            string materno = materno1.ToUpper();
            Console.WriteLine("Ingresa tu primer nombre: ");
            string nombre1 = Console.ReadLine();
            string nombre = nombre1.ToUpper();
            Console.WriteLine("Ingresa tu año de nacimiento(0,0,0,0)");
            string año = Console.ReadLine();
            Console.WriteLine("Ingresa tu mes de nacimiento(numeros:0,0)");
            string mes = Console.ReadLine();
            Console.WriteLine("Ingresa tu dia de nacimiento(numeros:0,0)");
            string dia = Console.ReadLine();
            Console.WriteLine("INGRESA TU SEXO");
            Console.WriteLine("MASCULINO: 1");
            Console.WriteLine("FEMENINO: 2");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            bool sexo = false;
            if (seleccion == 1 || seleccion == 2)
            {
                if (seleccion == 1)
                {
                    sexo = true;
                }
            }
            else
            {
                Console.WriteLine("ERROR! Disponibles: 1,2");
            }
            Console.WriteLine();
            Console.WriteLine("Selecciona tu entidad de nacimiento: ");
            Console.WriteLine("AGUAS CALIENTES: 1");
            Console.WriteLine("BAJA CALIFORNIA SUR: 2");
            Console.WriteLine("BAJA CALIFORNIA: 3");
            Console.WriteLine("CAMPECHE: 4");
            Console.WriteLine("COAHUILA: 5");
            Console.WriteLine("COLIMA: 6");
            Console.WriteLine("CHIAPAS: 7");
            Console.WriteLine("DISTRITO FEDERAL: 8");
            Console.WriteLine("CHIHUAHUA: 9");
            Console.WriteLine("DURANGO: 10");
            Console.WriteLine("GUANAJUATO: 11");
            Console.WriteLine("GUERRERO: 12");
            Console.WriteLine("HIDALGO: 13");
            Console.WriteLine("JALISCO: 14");
            Console.WriteLine("MEXICO: 15");
            Console.WriteLine("MICHUACAN: 16");
            Console.WriteLine("MORELOS: 17");
            Console.WriteLine("NAYARIT: 18");
            Console.WriteLine("NUEVO LEON: 19");
            Console.WriteLine("OAXACA: 20");
            Console.WriteLine("PUEBLA: 21");
            Console.WriteLine("QUERETARO: 22");
            Console.WriteLine("QUINTANA ROO: 23");
            Console.WriteLine("SAN LUIZ POTOSI: 24");
            Console.WriteLine("SINALOA: 25");
            Console.WriteLine("SONORA: 26");
            Console.WriteLine("TABASCO: 27");
            Console.WriteLine("TAMAULIPAS: 28");
            Console.WriteLine("TLAXCALA: 29");
            Console.WriteLine("VERACRUZ: 30");
            Console.WriteLine("YUCATAN: 31");
            Console.WriteLine("ZACATECAS: 32");
            Console.WriteLine("NACIDO EN EL EXTRANGERO: 33");
            int NumeroDeEntidad = Convert.ToInt32(Console.ReadLine());
            int EntidadPosicion = 0;
            for (int x = 1; x <= 33; x++)
            {
                if (NumeroDeEntidad == x)
                {
                    EntidadPosicion = NumeroDeEntidad;
                    break;
                }
                if (x == 33)
                {
                    Console.WriteLine("ERROR! Disponibles: 1-33");
                }
            }




            Console.WriteLine();
            Console.WriteLine("CURP GENERADO: ");
            Console.WriteLine(Prueba.DatosDeIngreso(paterno, materno, nombre, año, mes, dia, sexo, EntidadPosicion));

        }
    }
}

