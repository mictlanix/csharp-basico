using System;
using System.Collections.Generic;

namespace Delegados.Ejemplo02
{
    public class Principal
    {
        public static void Main(string[] args)
        {
			Tienda t = new Tienda();
			
			t.Operar();
        }
    }
	
	public delegate void Notificacion(object sender, string producto, int unidades);

	public class PuntoDeVenta
	{
	    public event Notificacion VentaRealizada;
		
		public double Vender(string producto, int cantidad, double precio)
		{
			VentaRealizada(this, producto, cantidad);
			
			return cantidad * precio;
		}
	}
	
	public class Tienda
	{
		private PuntoDeVenta pv;
		
		public Tienda()
		{
			pv = new PuntoDeVenta();
			pv.VentaRealizada += new Notificacion(Despachar);
		}
		
		public void Operar()
		{
			pv.Vender("Articulo X", 1, 273);
			pv.Vender("Articulo Y", 7, 3.15);
			pv.Vender("Articulo Z", 4, 83);
		}
		
		private void Despachar(object sender, string producto, int unidades)
		{
			Console.WriteLine("{0} {1} salen!", producto, unidades);
		}
	}
}
