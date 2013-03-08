using System;

namespace Herencia.Ejemplo01
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Persona p = new Persona();
            Cosa c = new Cosa();

            Console.WriteLine("p: {0}", p);
            Console.WriteLine("c: {0}", c);

            Console.WriteLine("Usando INombrable...");

            CambiarNombre(p, "Eddy Zavaleta");
            CambiarNombre(c, "Computadora");

            Console.WriteLine("p: {0}", p);
            Console.WriteLine("c: {0}", c);
        }

        public static void CambiarNombre(INombrable o, string nombre)
        {
            o.Nombre = nombre;
        }
    }

    public interface INombrable
    {
        string Nombre { get; set; }
    }

    public class Persona : INombrable
    {
        public Persona() : this("sin nombre")
        {
        }

        public Persona(string nombre)
        {
            Nombre = nombre;
            FechaNacimiento = DateTime.Now.Date;
        }

        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad  { get { return (DateTime.Now - FechaNacimiento).Days / 365; } }

        public override string ToString()
        {
            return string.Format("{0}, {1} años", Nombre, Edad);
        }
    }

    public class Cosa : INombrable
    {
        public Cosa()
        {
            Nombre = "sin nombre";
            FechaCaducidad = DateTime.Now.Date;
        }

        public string Nombre { get; set; }
        public DateTime FechaCaducidad { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1:d}", Nombre, FechaCaducidad);
        }
    }
}
