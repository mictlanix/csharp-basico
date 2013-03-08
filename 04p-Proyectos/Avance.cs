using System;
using System.IO;

namespace Practica
{
    public class Avance
    {
        public Actividad Actividad { get; private set; }
        public int Id { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Mensaje { get; private set; }
        public Usuario Autor { get; private set; }

        public Avance(Actividad actividad, string mensaje,
            Usuario autor)
        {
            this.Id = new Random().Next();
            this.Actividad = actividad;
            this.Mensaje = mensaje;
            this.Autor = autor;
            this.Fecha = DateTime.Now;
        }

        public override string ToString()
        {
            using (StringWriter w = new StringWriter())
            {
                w.WriteLine("    === Avance ===");
                w.WriteLine("    Mensaje: {0}", this.Mensaje);

                return w.ToString();
            }
        }
    }
}
