using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EnClase
{
    class TryCatchClase
    {
        public void HacerMagia()
        {

            object o = "sda";
            try
            {
                int a = 0;
                int x = 0 / a;
                int i2 = (int)o;
                Console.WriteLine($"Cast {i2}");
              
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"DivideByZeroException");                
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hubo un error por favor intenta mas tarde");
            }

            Console.WriteLine($"FIN");
        }
    }
}
