using System;
using System.Collections.Generic;

namespace Herencia.Ejemplo02
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            List<Cosa> lista = CrearListaAleatoria("cosa", 7);

            Console.WriteLine("Lista Desordenada");

            foreach(Cosa c in lista)
            {
                Console.WriteLine(c);
            }

            lista.Sort();

            Console.WriteLine("Lista Ordenada");

            foreach(Cosa c in lista)
            {
                Console.WriteLine(c);
            }
        }

        public static List<Cosa> CrearListaAleatoria(string prefijo, int n)
        {
            List<Cosa> lista = new List<Cosa>();
            Random rand = new Random();
            string nombre;

            for(int i = 0; i < n; i++)
            {
                nombre = string.Format("{0}#{1:00}", prefijo, rand.Next() % 99);
                lista.Add(new Cosa(nombre));
            }

            return lista;
        }
    }

    public class Cosa : IComparable
    {
        public Cosa() : this("sin nombre")
        {
        }

        public Cosa(string nombre)
        {
            Nombre = nombre;
            FechaCaducidad = DateTime.Now.Date;
        }

        public string Nombre { get; set; }
        public DateTime FechaCaducidad { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1:d}", Nombre, FechaCaducidad);
        }

        public int CompareTo (object obj)
        {
            Cosa c = obj as Cosa;
            int resultado;

            if(c == null)
                return this.Nombre.Length;

            resultado = this.Nombre.CompareTo(c.Nombre);

            if(resultado == 0)
                return this.FechaCaducidad.CompareTo(c.FechaCaducidad);

            return resultado;
        }
    }
}
