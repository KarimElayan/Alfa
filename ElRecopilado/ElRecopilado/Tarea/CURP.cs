using System;

namespace CURP
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string año,nombre,ap,am, estado, genero,o,np,no,nw;
            int dia, mes;
            
            Console.WriteLine(" CURP ");
           
            Console.WriteLine("Ingrese su nombre de Pila: ");
            nombre = Console.ReadLine();
            nombre = nombre.ToUpper();
            Console.WriteLine("Ingrese la primer consonante interna del nombre de pila: ");
            np = Console.ReadLine();
            np = np.ToUpper();
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese su apellido paterno: ");
            ap = Console.ReadLine();
            ap = ap.ToUpper();
            Console.WriteLine("Ingrese la primer vocal del apellido paterno: ");
            o = Console.ReadLine();
            o = o.ToUpper();
            Console.WriteLine("Ingrese la primer consonante interna del apellido Paterno: ");
            no = Console.ReadLine();
            no = no.ToUpper();
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese su apellido Materno: ");
            am = Console.ReadLine();
            am = am.ToUpper();
            Console.WriteLine("Ingrese la primer consonante interna del apellido Materno: ");
            nw = Console.ReadLine();
            nw = nw.ToUpper();
            Console.WriteLine(" ");


            do
            {
                Console.WriteLine("FECHA DE NACIMIENTO... ");
                Console.WriteLine("DIA: ");
                dia = Convert.ToInt32(Console.ReadLine());
                
                
            } while (dia > 31 || dia < 1);

            do
            {
                Console.WriteLine("MES: ");
                mes = Convert.ToInt32(Console.ReadLine());

            } while (mes > 12 || mes < 1);

                Console.WriteLine("AÑO: ");
                año = Console.ReadLine();

            do
            {
                Console.WriteLine("ESTADO DE NACIMIENTO:  ");
                Console.WriteLine("En caso de ser nacido en el extranjero poner (NE).");
                estado = Console.ReadLine();
                estado = estado.ToUpper();
                if (estado == "AGUASCALIENTES")
                    estado = "AS";
                else if (estado == "BAJA CALIFORNIA SUR")
                    estado = "BS";
                else if (estado == "BAJA CALIFORNIA ")
                    estado = "BC";
                else if (estado == "COAHUILA")
                    estado = "CL";
                else if (estado == "CHIAPAS")
                    estado = "CS";
                else if (estado == "DISTRITO FEDERAL")
                    estado = "DF";
                else if (estado == "GUANAJUATO")
                    estado = "GT";
                else if (estado == "HIDALGO")
                    estado = "HG";
                else if (estado == "MEXICO")
                    estado = "MC";
                else if (estado == "MORELOS")
                    estado = "MS";
                else if (estado == "NUEVO LEON")
                    estado = "NL";
                else if (estado == "PUEBLA")
                    estado = "PL";
                else if (estado == "QUINTANA ROO")
                    estado = "QR";
                else if (estado == "SINALOA")
                    estado = "SL";
                else if (estado == "TABASCO")
                    estado = "TC";
                else if (estado == "TLAXCALA")
                    estado = "TL";
                else if (estado == "YUCATAN")
                    estado = "YN";
                else if (estado == "CAMPECHE")
                    estado = "CC";
                else if (estado == "COLIMA")
                    estado = "CM";
                else if (estado == "CHIHUAHUA")
                    estado = "CH";
                else if (estado == "DURANGO")
                    estado = "DG";
                else if (estado == "GUERRERO")
                    estado = "GR";
                else if (estado == "JALISCO")
                    estado = "LC";
                else if (estado == "MICHOACAN")
                    estado = "MN";
                else if (estado == "NAYARIT")
                    estado = "NT";
                else if (estado == "OAXACA")
                    estado = "OC";
                else if (estado == "QUERETARO")
                    estado = "QT";
                else if (estado == "SAN LUIS POTOSI")
                    estado = "SP";
                else if (estado == "SONORA")
                    estado = "SR";
                else if (estado == "TAMAULIPAS")
                    estado = "TS";
                else if (estado == "VERACRUZ")
                    estado = "VZ";
                else if (estado == "ZACATECAS")
                    estado = "ZS";
                else if (estado == "NE")
                    estado = "NE";
            } while (estado != "AS" || estado != "BS" || estado != "CL" || estado != "CS" || estado != "DF" || estado != "GT" || estado != "HG" || estado != "MC" || estado != "MS" || estado != "NL" || estado != "PL" || estado != "QR" || estado != "SL" || estado != "TS" || estado != "TL" || estado != "YN" || estado != "NE" || estado != "BC" || estado != "CC" || estado != "CM" || estado != "CH" || estado != "DG" || estado != "GR" || estado != "JC" || estado != "MN" || estado != "NT" || estado != "OC" || estado != "QT" || estado != "SP" || estado != "SR" || estado != "TS" || estado != "VZ" || estado != "ZS ");

            do
            {
                Console.WriteLine("GENERO (Mujer/Hombre):  ");
                genero = Console.ReadLine();
                genero = genero.ToUpper();
                if (genero == "MUJER" || genero == "M")
                    genero = "M";
                else if (genero == "HOMBRE" || genero == "H")
                    genero = "H";
                Console.WriteLine("Ingrese una opcion valida");
            } while (genero != "MUJER" && genero != "M" && genero != "HOMBRE" && genero != "H");

                Console.WriteLine();
                Console.WriteLine("DATOS:");

            if (mes < 10 && mes > 0)
            {
                if (dia < 10 && dia > 0)
                    Console.WriteLine("curp " + ap[0] +o+ am[0] + nombre[0] + año[2] + año[3] + "0" + mes +"0"+ dia + genero + estado+no+nw+np+"09");
                else if (dia > 9 && dia < 31)
                    Console.WriteLine("curp " + ap[0] +o+ am[0] + nombre[0] + año[2] + año[3] + "0" + mes + dia + genero + estado+no+nw+np+"09");
            }
            else if (mes > 9 && mes < 13)
            if (dia < 10 && dia > 0 )
                Console.WriteLine("curp " + ap[0] +o+ am[0] + nombre[0] + año[2] + año[3] + mes +"0" + dia + genero + estado+no+nw+np+"09");
            
            else if (dia > 9 && dia < 31)
                Console.WriteLine("curp " + ap[0] +o+ am[0] + nombre[0] +año[2]+año[3]+ mes + dia + genero + estado+no+nw+np+"09");
        }
    }
}
