using System;

namespace Clases.Ejemplo01
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Persona p = new Persona();

            p.Saludar();
            p.Saludar("juan");
        }
    }

    public class Persona
    {
        private const string SALUDO ="Hola mundo!";
        private const string SALUDO_PARAMETRIZADO = "Hola {0}!";

        public void Saludar()
        {
            Console.WriteLine (SALUDO);
        }

        public void Saludar(string nombre)
        {
            Console.WriteLine (SALUDO_PARAMETRIZADO, nombre);
        }
    }
}
