using System;

namespace Practica
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Usuario admin = new Usuario { Nombre = "El Jefe", Rol = Rol.Supervisor };
            Usuario usuario = new Usuario { Nombre = "El Chalán", Rol = Rol.Usuario };
            Proyecto proy = new Proyecto("PRT-1004",
                "Proyecto CSharp", admin, usuario,
                new DateTime(2010, 04, 20),
                new DateTime(2010, 05, 30));

            proy.NuevaActividad("Realizar Práctica 1", usuario, usuario,
                new DateTime(2010, 04, 20),
                new DateTime(2010, 05, 30));
            proy.NuevaActividad("Realizar Práctica 2", usuario, usuario,
                new DateTime(2010, 04, 20),
                new DateTime(2010, 05, 30));
            proy.NuevaActividad("Realizar Práctica 3", usuario, usuario,
                 new DateTime(2010, 04, 20),
                 new DateTime(2010, 05, 30));

            proy.Actividades[1].NuevoAvance("Ya me atore", usuario);
            proy.Actividades[1].NuevoAvance("Apurale mano", admin);

            Console.WriteLine(proy);
            Console.Read();
        }
    }
}
