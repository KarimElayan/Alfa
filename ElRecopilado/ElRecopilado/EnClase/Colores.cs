using System;
using System.Collections.Generic;
using System.Text;

namespace ElRecopilado.EnClase
{
    class Colores
    {
        public int color;
        public float grosor;
        public bool hasPunta;
        public string ToString()
        {
            return $"[color: {color} grosor: {grosor} hasPunta: {hasPunta}]";
            //return "[color: "+ color +"grosor: " + grosor + "hasPunta" + hasPunta+ "]";
        }
    }
}
