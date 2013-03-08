using System;

namespace Sentencias
{
    class SentenciaContinue
    {
        public static void Main (string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    continue;

                System.Console.WriteLine(i);
            }
        }
    }
}
