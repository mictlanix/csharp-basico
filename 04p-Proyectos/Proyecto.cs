using System;
using System.Collections.Generic;
using System.IO;

namespace Practica
{
    public enum EstadoProyecto
    {
        Nuevo,
        EnProceso,
        Terminada
    }

    public class Proyecto
    {
        public List<Actividad> actividades;

        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Inicio { get; private set; }
        public DateTime Fin { get; private set; }
        public Usuario Responsable { get; private set; }
        public Usuario Autor { get; private set; }
        public EstadoProyecto Status { get; set; }
        public List<Actividad> Actividades { get { return actividades; } }

        public Proyecto(string clave, string nombre,
            Usuario autor, Usuario responsable,
            DateTime inicio, DateTime fin)
        {
            if (fin <= DateTime.Now.Date)
                throw new ArgumentOutOfRangeException("fin");

            if (fin <= inicio)
                throw new ArgumentException("El fin de proyecto de ser después al inicio.");

            this.Status = EstadoProyecto.Nuevo;
            this.Clave = clave;
            this.Nombre = nombre;
            this.Inicio = inicio;
            this.Fin = fin;
            this.Autor = autor;
            this.Responsable = responsable;

            this.actividades = new List<Actividad>();
        }

        public Actividad NuevaActividad(string nombre,
            Usuario autor, Usuario responsable,
            DateTime inicio, DateTime fin)
        {
            Actividad actividad = new Actividad(this, nombre,
                inicio, fin, autor, responsable);
            
            actividades.Add(actividad);
            this.Status = EstadoProyecto.EnProceso;

            return actividad;
        }

        public override string ToString()
        {
            using (StringWriter w = new StringWriter())
            {
                w.WriteLine("= Proyecto =");
                w.WriteLine("Clave: {0}", this.Clave);
                w.WriteLine("Nombre: {0}", this.Nombre);
                w.WriteLine("Periodo: {0:d} - {1:d}", this.Inicio, this.Fin);

                foreach (Actividad actividad in this.Actividades)
                {
                    w.WriteLine(actividad);
                }

                return w.ToString();
            }
        }
    }
}
