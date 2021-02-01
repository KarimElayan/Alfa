namespace ElRecopilado.EnClase
{
    class Colores
    {
        public int color;
        public float grosor;
        public bool hasPunta;

        public Colores()
        {
            color = -1;
            grosor = -1.9f;
            hasPunta = false;
        }
        public Colores(int numeroX, float grosor)
        {
            color = numeroX;
            this.grosor = grosor;
            hasPunta = true;
        }

        public Colores(int color, float grosor, bool x)
        {
            this.color = color;
            this.grosor = grosor;
            hasPunta = x;
        }

        public string ToString()
        {
            return $"[color: {color} grosor: {grosor} hasPunta: {hasPunta}]";
            //return "[color: "+ color +"grosor: " + grosor + "hasPunta" + hasPunta+ "]";
        }
    }
}
