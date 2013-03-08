using System;
using System.Collections.Generic;

namespace Iteradores.Ejemplo01
{
	public class Principal
	{
		private static IEnumerable<DateTime> GenerarInstantes()
		{
			DateTime limite = DateTime.Now + new TimeSpan(0, 0, 3);
			
			while (DateTime.Now < limite)
			{
				yield return DateTime.Now;
			}
			
			yield break;
		}
		
		public static void Main (string[] args)
		{
			foreach (DateTime d in GenerarInstantes())
			{
				System.Console.WriteLine(d);
			}
		}
	}
}