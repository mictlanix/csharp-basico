using System;

namespace Sentencias
{
    class SentenciaBreak
    {
        public static void Main (string[] args)
        {
            for(int i = 1; i < 100; i++)
            {
                System.Console.WriteLine(i);
            
                if (i % 2 == i / 2)
                    break;
            }
        }
    }
}
