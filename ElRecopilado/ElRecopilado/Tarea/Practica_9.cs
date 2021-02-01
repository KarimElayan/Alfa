using System;
using System.Collections.Generic;


namespace Tarea
{
    class Practica_9
    {
        
        static void Main(string[] args)
        {
        int i =1;
          Console.WriteLine("TOLAS SE INGRESA EN MAYUSCULAS :)");
          int estado ;
          Boolean Condicion= false;
          String EntidadFederativa="",AM,AP,NM,G,Curp="";
          Console.WriteLine("Apellido Paterno");
          AP=Console.ReadLine(); 
         
          Console.WriteLine("Apellido Materno");
          AM=Console.ReadLine(); 
          Console.WriteLine("Nombre(s)");
          NM=Console.ReadLine(); 
          Console.WriteLine("Genero H.- Hombre M.- Mujer");
          G=Console.ReadLine(); 
         Console.WriteLine("Año a 4 digitos 0000");
          String Year=Console.ReadLine();
          Console.WriteLine("# Mes");
          String Mes=Console.ReadLine();
           Console.WriteLine("# DIA");
          String Dia=Console.ReadLine();

          Console.WriteLine("#Estado");
          String Cas=Console.ReadLine();   
            estado=int.Parse(Cas);
 Curp+=AP[0];      
do
     {
         if(AP[i]=='A'||AP[i]=='E'||AP[i]=='I'|AP[i]=='O'||AP[i]=='U')
         {
             Console.WriteLine("Estado");
                Curp+=AP[i];
                Condicion=true;
         }
         else{
             i++;
             Condicion=false;
         }

     } while (!Condicion);
     Curp+=AM[0];
     Curp+=NM[0];
     Curp+=Year[2];
      Curp+=Year[3];
      Curp+=Mes[0];
      Curp+=Mes[1];
      Curp+=Dia[0];
      Curp+=Dia[1];
      Curp+=G;
     


          switch (estado)
{

//AGUASCALIENTES
case 1:
EntidadFederativa = "AS";
break;
//BAJA CALIFORNIA
case 2:
EntidadFederativa = "BC";
break;
//BAJA CALIFORNIA SUR
case 3:
EntidadFederativa = "BS";
break;
//CAMPECHE
case 4:
EntidadFederativa = "CC";
break;
//COAHUILA
case 5:
EntidadFederativa = "CL";
break;
//COLIMA
case 6:
EntidadFederativa = "CM";
break;
//CHIAPAS
case 7:
EntidadFederativa = "CS";
break;
//CHIHUAHUA
case 8:
EntidadFederativa = "CH";
break;
//DISTRITO FEDERAL
case 9:
EntidadFederativa = "DF";
break;
//DURANGO
case 10:
EntidadFederativa = "DG";
break;
//GUANAJUATO
case 11:
EntidadFederativa = "GT";
break;
//GUERRERO
case 12:
EntidadFederativa = "GR";
break;
//HIDALGO
case 13:
EntidadFederativa = "HG";
break;
//JALISCO
case 14:
EntidadFederativa = "JC";
break;
//MEXICO
case 15:
EntidadFederativa = "MC";
break;
//MICHOACAN
case 16:
EntidadFederativa = "MN";
break;
//MORELOS
case 17:
EntidadFederativa = "MS";
break;
//NAYARIT
case 18:
EntidadFederativa = "NT";
break;
//NUEVO LEON
case 19:
EntidadFederativa = "NL";
break;
//OAXACA
case 20:
EntidadFederativa = "OC";
break;
//PUEBLA
case 21:
EntidadFederativa = "PL";
break;
//QUERETARO
case 22:
EntidadFederativa = "QT";
break;
//QUINTANA ROO
case 23:
EntidadFederativa = "QR";
break;
//SAN LUIS POTOSI
case 24:
EntidadFederativa = "SP";
break;
//SINALOA
case 25:
EntidadFederativa = "SL";
break;
//SONORA
case 26:
EntidadFederativa = "SR";
break;
//QUINTANA ROO
case 27:
EntidadFederativa = "QR";
break;
//TABASCO
case 28:
EntidadFederativa = "TC";
break;
//TAMAULIPAS
case 29:
EntidadFederativa = "TS";
break;
//TLAXCALA
case 30:
EntidadFederativa = "TL";
break;
//VERACRUZ
case 31:
EntidadFederativa = "VZ";
break;
//YUATAN
case 32:
EntidadFederativa = "YN";
break;
//ZACATECAS
default:
EntidadFederativa = "ZS";
break;
}
Curp+=EntidadFederativa;
Condicion=false;
i =1;
do
     {
         if(NM[i]!='A'||NM[i]!='E'||NM[i]!='I'||NM[i]!='O'||NM[i]!='U')
         {
             
                Curp+=NM[i];
                Condicion=true;
         }
         else{
             i++;
             Condicion=false;
         }
         } while (!Condicion);
         Condicion=false;
         i =1;
         do
     {
         if(AM[i]!='A'||AM[i]!='E'||AM[i]!='I'||AM[i]!='O'||AM[i]!='U')
         {
             
                Curp+=AM[i];
                Condicion=true;
         }
         else{
             i++;
             Condicion=false;
         }
        } while (!Condicion);
        i =1;
        do
     {
         if(AP[i]!='A'||AP[i]!='E'||AP[i]!='I'||AP[i]!='O'||AP[i]!='U')
         {
             
                Curp+=AP[i];
                Condicion=true;
         }
         else{
             i++;
             Condicion=false;
         }
        } while (!Condicion);



Console.WriteLine(Curp);
 

        }
      



       


    }    
}


