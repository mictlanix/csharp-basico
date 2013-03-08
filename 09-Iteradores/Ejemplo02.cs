using System;
using System.Collections.Generic;

namespace Iteradores.Ejemplo02
{
	public class Principal
	{
		private static IEnumerable<int> DesdeHasta(int inicio, int fin)
        {
            while (inicio <= fin)
            {
                yield return inicio++;
            }
        }
		
		public static void Main (string[] args)
		{
            IEnumerable<int> e = DesdeHasta(1, 10);

            foreach (int x in e)
            {
                foreach (int y in e)
                {
                    Console.Write("{0,3} ", x * y);
                }

                Console.WriteLine();
            }
		}
	}
}