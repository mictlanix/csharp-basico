using System;

namespace TiposParciales.Ejemplo01
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Cilindro c = new Cilindro();
        
            c.Radio = 5.20;
            c.Altura = 28.35;
    
            Imprimir(c);
        }
        
        private static void Imprimir(Cilindro c)
        {
            Console.WriteLine("Radio: {0}", c.Radio);
            Console.WriteLine("Altura: {0}", c.Altura);
            Console.WriteLine("Volumen: {0}", c.Volumen());
        }
    }
}