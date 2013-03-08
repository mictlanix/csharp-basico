using System;

namespace Excepciones
{
    class SentenciaThrow
    {
        public static void PedirHelado(string sabor)
        {
            switch(sabor)
            {
            case "chocolate":
                Console.WriteLine("se pidio un helado de chocolate");
                break;
            case "vainilla":
                Console.WriteLine("se pidio un helado de vainilla");
                break;
            default:
                throw new Exception("no hay sabor " + sabor);
            }
        }

        public static void Main(string[] args)
        {
            try {
                PedirHelado("vainilla");
                PedirHelado("fresa");
                PedirHelado("chocolate");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
