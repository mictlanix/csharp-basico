using System;

namespace Excepciones
{
    class SentenciaTry
    {
        public static int long2int(long x)
        {
            return checked((int)x);
        }

        public static void Main(string[] args)
        {

            int i = int.MaxValue;
            long l = long.MaxValue;

            try {
                i = long2int(l);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("hubo un error... {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("i: {0} y l: {1}", i, l);
            }
        }
    }
}
