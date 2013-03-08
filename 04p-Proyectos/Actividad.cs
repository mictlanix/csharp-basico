using System;
using System.Collections.Generic;
using System.IO;

namespace Practica
{
    public enum Categoria
    {
        Desarrollo,
        Pruebas,
        Documentacion,
        Otro
    }

    public enum EstadoActividad
    {
        Nuevo,
        EnProceso,
        Aplazada,
        Terminada
    }

    public class Actividad
    {
        private List<Avance> avances;
        private DateTime fin;

        public int Id { get; set; }
        public Proyecto Proyecto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Inicio { get; private set; }
        public DateTime Fin
        { 
            get { return fin; }
            set
            {
                fin = value;
                Status = EstadoActividad.Aplazada;
            }
        }
        public Usuario Responsable { get; private set; }
        public Usuario Autor { get; private set; }
        public float PorcentajeCumplido { get; set; }
        public float Ponderacion { get; set; }
        public EstadoActividad Status { get; set; }
        public List<Avance> Avances { get { return avances; } }

        public Actividad(Proyecto proyecto, string nombre,
            DateTime inicio, DateTime fin,
            Usuario autor, Usuario responsable)
        {
            if (fin > proyecto.Fin)
                throw new ArgumentOutOfRangeException("fin");

            if (inicio < DateTime.Now.Date)
                throw new ArgumentOutOfRangeException("inicio");

            if (fin <= inicio)
                throw new ArgumentException("El fin de proyecto de ser después al inicio.");

            this.Id = new Random().Next();
            this.Proyecto = proyecto;
            this.Nombre = nombre;
            this.Inicio = inicio;
            this.Fin = fin;
            this.Autor = autor;
            this.Status = EstadoActividad.Nuevo;

            this.avances = new List<Avance>();
        }

        public Avance NuevoAvance(string nombre, Usuario autor)
        {
            Avance avance = new Avance(this, nombre, autor);

            avances.Add(avance);
            this.Status = EstadoActividad.EnProceso;

            return avance;
        }
        public override string ToString()
        {
            using (StringWriter w = new StringWriter())
            {
                w.WriteLine("  == Actividad ==");
                w.WriteLine("  Nombre: {0}", this.Nombre);
                w.WriteLine("  Descripción: {0}", this.Descripcion);

                foreach (Avance avance in this.Avances)
                {
                    w.WriteLine(avance);
                }

                return w.ToString();
            }
        }
    }
}
