using System;

namespace Sentencias
{
    class SentenciaChecked
    {
        public static void Main (string[] args)
        {
            int i = int.MaxValue;
            long l = long.MaxValue;

            checked
            {
                i = (int)l;
            }

            Console.WriteLine("i: {0} y l: {1}", i, l);
        }
    }
}
