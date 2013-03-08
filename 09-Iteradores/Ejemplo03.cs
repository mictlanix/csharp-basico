using System;
using System.Collections;
using System.Collections.Generic;

namespace Iteradores.Ejemplo03
{
    public class Pila<T> : IEnumerable<T>
    {
        private T[] elems;
        private int cuenta;

        public void Meter(T elem)
        {
            if (elems == null)
            {
                elems = new T[4];
            }
            else if (elems.Length == cuenta)
            {
                T[] nuevos_elems = new T[cuenta * 2];
    
                Array.Copy(elems, 0, nuevos_elems, 0, cuenta);
    
                elems = nuevos_elems;
            }
    
            elems[cuenta++] = elem;
        }
    
        public T Sacar()
        {
            T result = elems[--cuenta];
    
            elems[cuenta] = default(T);
    
            return result;
        }

        public int Cuenta
        {
            get { return cuenta; }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = cuenta - 1; i >= 0; --i)
                yield return elems[i];
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotSupportedException();
        }
    }
    
    public class Principal
    {
        public static void Main (string[] args)
        {
            Pila<int> p = new Pila<int>();
            
            p.Meter(10);
            p.Meter(8);
            p.Meter(6);
            p.Meter(4);
            p.Meter(2);
            
            foreach (int x in p)
            {
                Console.WriteLine("{0}", x);
            }
        }
    }
}