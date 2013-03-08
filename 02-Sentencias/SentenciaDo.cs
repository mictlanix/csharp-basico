using System;

namespace Sentencias
{
    class SentenciaDo
    {
        public static void Main (string[] args)
        {
            int numero = 0;
            
            do
            {
                Console.WriteLine(numero++);
            } while (numero < 10);
        }
    }
}
