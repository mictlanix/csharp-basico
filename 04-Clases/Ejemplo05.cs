using System;

namespace Clases.Ejemplo05
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Persona p1 = new Persona();

            Console.WriteLine("{0}", p1);

            Console.WriteLine("cambios a p1...");

            p1.Nombre = "Eddy Zavaleta";
            p1.FechaNacimiento = new DateTime(1986, 4, 22);
            p1.Sexo = Sexo.Masculino;

            Console.WriteLine("{0}", p1);
        }
    }

    public enum Sexo
    {
        Indefinido,
        Femenino,
        Masculino
    }

    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private Sexo sexo;

        public Persona()
        {
            nombre = "sin nombre";
            fechaNacimiento = DateTime.Now.Date;
            sexo = Sexo.Indefinido;
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

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
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
            return string.Format("{0}, {1} años, Sexo: {2}", nombre, CalcularEdad(), sexo);
        }
    }
}
