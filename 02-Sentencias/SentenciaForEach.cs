using System;

namespace Sentencias
{
    class SentenciaForEach
    {
        public static void Main (string[] args)
        {
            string[] elementos = {"uno", "dos", "tres"};
            
            foreach (string elemento in elementos)
            {
                System.Console.WriteLine(elemento);
            }
        }
    }
}
