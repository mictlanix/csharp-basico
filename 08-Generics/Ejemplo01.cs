using System;

namespace Generics.Ejemplo01
{
    public class ContenedorDeObjetos<T>
    {
        private T obj;
    
        public ContenedorDeObjetos(T obj)
        {
            this.obj = obj;
        }
    
        public T Objeto
        {
            get { return this.obj; }
        }
    }
	
	public class Principal
	{
		public static void Main (string[] args)
		{
			ContenedorDeObjetos<int> container = new ContenedorDeObjetos<int>(25);
			ContenedorDeObjetos<int> container2 = new ContenedorDeObjetos<int>(5);
			Console.WriteLine(container.Objeto + container2.Objeto);
		}
	}
}
