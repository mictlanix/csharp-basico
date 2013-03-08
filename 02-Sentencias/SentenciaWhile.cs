using System;

namespace Sentencias
{
    class SentenciaWhile
    {
        public static void Main (string[] args)
        {
            TimeSpan duracion = new TimeSpan(0, 0, 30);
            DateTime inicio = DateTime.Now;

            while (DateTime.Now - inicio < duracion)
            {
                Console.WriteLine("esperando...");
            }
            
            Console.WriteLine("listo!");
        }
    }
}
