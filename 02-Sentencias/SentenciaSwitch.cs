using System;

namespace Sentencias
{
    class SentenciaSwitch
    {
        public static void Main (string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
            case 0:
            case 1:
                Console.WriteLine("Opcion Uno");
                break;
            case 2:
                Console.WriteLine("Opcion Dos");
                break;
            case 3:
                Console.WriteLine("Opcion Tres");
                break;
            default:
                Console.WriteLine("Opcion desconocida");
                break;
            }

        }
    }
}
