using System;
using System.Collections.Generic;
using Herencia.Ejemplo01;

namespace Herencia.Ejemplo03
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();

            lista.Add(new Persona("Eddy"));
            lista.Add(new Empleado("Eddy", "CTO"));
            lista.Add(new Cliente("Eddy", 0.1f));

            foreach(Persona c in lista)
            {
                Console.WriteLine(c);
            }
        }
    }

    public class Empleado : Persona
    {
        public Empleado Jefe { get; set; }
        public decimal Sueldo { get; set; }
        public string Puesto { get; set; }

        public Empleado(string nombre, string puesto) : base(nombre)
        {
            this.Puesto = puesto;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Nombre, Puesto);
        }
    }

    public class Cliente : Persona
    {
        public Empleado Agente { get; set; }
        public float Descuento { get; set; }

        public Cliente(string nombre, float descuento) : base(nombre)
        {
            this.Descuento = descuento;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1:p}", Nombre, Descuento);
        }
    }
}
