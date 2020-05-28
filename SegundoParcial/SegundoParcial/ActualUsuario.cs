namespace SegundoParcial
{
    public static class ActualUsuario
    {
        private static string persona;
        private static int id;

        public static void personaActual(string cadena)
        {
            persona = cadena;
        }
        
        public static void IdActual(int numero)
        {
            id = numero;
        }

        public static string Persona
        {
            get => persona;
        }

        public static int Id
        {
            get => id;
        }
    }
}