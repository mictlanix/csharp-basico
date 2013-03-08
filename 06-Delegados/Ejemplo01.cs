using System;
using System.Collections.Generic;

namespace Delegados.Ejemplo01
{
    public class Principal
    {
        public static void Main(string[] args)
        {
			Procedimiento pasos = null;
			Metodos m1 = new Metodos("m1");
			Metodos m2 = new Metodos("m2");
			
			pasos += new Procedimiento(Metodos.Metodo1);
			pasos += new Procedimiento(Metodos.Metodo2);
			pasos += new Procedimiento(m1.Metodo3);
			pasos += new Procedimiento(m2.Metodo3);
			
			pasos(10);
			
			pasos -= new Procedimiento(Metodos.Metodo2);
			pasos -= new Procedimiento(m1.Metodo3);
			
			Console.WriteLine();
			pasos(20);
        }

    }
	
	public delegate void Procedimiento(int valor);
	
	public class Metodos
	{
		private string nombre;
		
		public Metodos(string nombre)
		{
			this.nombre = nombre;
		}
		
		public static void Metodo1(int valor)
		{
			Console.WriteLine("Metodo1({0})", valor);
		}
		
		public static void Metodo2(int valor)
		{
			Console.WriteLine("Metodo2({0})", valor);
		}
		
		public void Metodo3(int valor)
		{
			Console.WriteLine("Metodo3({0}) [{1}]", valor, nombre);
		}
	}
}
