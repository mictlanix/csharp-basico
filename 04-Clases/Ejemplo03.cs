using System;
using Clases.Ejemplo02;

namespace Clases.Ejemplo03
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Personas p = new Personas();

            Console.WriteLine(p["Persona 03"]);
        }
    }

    public class Personas
    {
        private Persona[] datos;

        public Personas() : this (10)
        {
        }

        public Personas(int n)
        {
            datos = new Persona[n];

            for(int i = 0; i < n; i++)
            {
                datos[i] = new Persona();
                datos[i].Nombre = string.Format("Persona {0:00}", i);
                datos[i].FechaNacimiento = new DateTime(1980, 1, 1).AddYears(i);
            }
        }

        public Persona this[string nombre]
        {
            get {
                foreach(Persona p in datos)
                {
                    if(p.Nombre == nombre)
                        return p;
                }

                throw new IndexOutOfRangeException("El nombre no se encontro");
            }
        }
    }
}
