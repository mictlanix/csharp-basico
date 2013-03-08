using System;

namespace Practica
{
    public enum Rol
    {
        Supervisor,
        Usuario
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Rol Rol { get; set; }
    }
}
