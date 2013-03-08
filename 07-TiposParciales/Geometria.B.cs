using System;

namespace TiposParciales.Ejemplo01
{
    public partial class Cilindro
    {
        public Cilindro()
        {
            this.radio = 0.00;
            this.altura = 0.00;
        }
    
        public double Volumen()
        {
            return radio * radio * altura * Math.PI;
        }
    }
}
