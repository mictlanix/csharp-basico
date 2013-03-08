using System;

namespace MetodosAnonimos.Ejemplo01
{
    public delegate bool Probar<T>(T item);
    
    public class Buscador
    {
        public static T Encontrar<T>(T[] elems, Probar<T> prueba)
        {
            foreach (T elem in elems)
            {
                if (prueba(elem))
                    return elem;
            }
    
            throw new InvalidOperationException("No se encontro el elemento.");
        }
    }
	
	public class Principal
	{
		public static void Main (string[] args)
		{
            string[] lista = new string[] { "uno", "dos", "tres", "cuatro", "cinco" };
			
            Console.WriteLine(Buscador.Encontrar(lista, delegate(string elem) {
                return "tres".Equals(elem);
            }));
		}
	}
}
