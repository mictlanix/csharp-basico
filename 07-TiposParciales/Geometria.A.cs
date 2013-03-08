using System;

namespace TiposParciales.Ejemplo01
{
    public partial class Cilindro
    {
        private double radio;
        private double altura;
    
        public Cilindro(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
    
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
    }
}
