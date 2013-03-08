using System;

namespace Generics.Ejemplo02
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
        private static bool BuscarTres(string elem)
        {
            return "tres".Equals(elem);
        }
        
		public static void Main (string[] args)
		{
            string[] lista = new string[] { "uno", "dos", "tres", "cuatro", "cinco" };
			
            Console.WriteLine(Buscador.Encontrar(lista, BuscarTres));
		}
	}
}
