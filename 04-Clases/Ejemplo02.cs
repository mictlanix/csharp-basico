using System;

namespace Clases.Ejemplo02
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = p1;

            Console.WriteLine("p1: {0}", p1);
            Console.WriteLine("p2: {0}", p2);

            Console.WriteLine("cambios a p1...");

            p1.Nombre = "Eddy Zavaleta";
            p1.FechaNacimiento = new DateTime(1986, 4, 22);

            Console.WriteLine("p1: {0}", p1);
            Console.WriteLine("p2: {0}", p2);
        }
    }

    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;

        public Persona()
        {
            nombre = "sin nombre";
            fechaNacimiento = DateTime.Now.Date;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get { return CalcularEdad(); }
        }

        private int CalcularEdad()
        {
            TimeSpan dif = DateTime.Now - fechaNacimiento;

            return dif.Days / 365;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} años", nombre, CalcularEdad());
        }
    }
}
