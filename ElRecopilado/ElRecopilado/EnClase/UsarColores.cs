using System;

namespace ElRecopilado.EnClase
{
    class UsarColores
    {
        public void HacerMagia()
        {
            Colores color1 = new Colores();
            color1.color = 1;
            color1.grosor = 0.5f;
            color1.hasPunta = true;

            Colores color2 = new Colores()
            {
                color = 2,
                grosor = 1,
                hasPunta = true
            };

            Console.WriteLine(color1.ToString());
            Console.WriteLine(color2.ToString());

        }
    }
}
