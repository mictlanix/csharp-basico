using System;
using System.Collections.Generic;

namespace Herencia.Ejemplo04
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Rectangulo f1 = new Rectangulo(2, 4);
            Cuadrado f2 = new Cuadrado(2);
            Circulo f3 = new Circulo(2);
            Triangulo f4 = new Triangulo(2, 6);

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(f4);
        }

        public interface IFigura
        {
            double Ancho { get; set; }
            double Largo { get; set; }
            double Area();
        }

        public class Rectangulo : IFigura
        {
            protected double valor_x;
            protected double valor_y;

            public Rectangulo(double ancho, double largo)
            {
                this.valor_x = ancho;
                this.valor_y = largo;
            }

            public virtual double Ancho
            {
                get { return valor_x; }
                set { valor_x = value; }
            }

            public virtual double Largo
            {
                get { return valor_y; }
                set { valor_y = value; }
            }

            public virtual double Area()
            {
                return valor_x * valor_y;
            }

            public override string ToString()
            {
                return string.Format("Rectangulo [{0}x{1}, {2} m2]", Ancho, Largo, Area());
            }
        }

        public class Cuadrado : Rectangulo
        {
            public Cuadrado(double lado) : base(lado, lado)
            {
            }

            public override double Ancho { set { Lado = value; } }
            public override double Largo { set { Lado = value; } }

            public double Lado
            {
                get { return valor_x; }
                set
                {
                    valor_x = value;
                    valor_y = value;
                }
            }

            public override string ToString()
            {
                return string.Format("Cuadrado [{0}x{1}, {2} m2]", Ancho, Largo, Area());
            }
        }

        public class Triangulo : Rectangulo
        {
            public Triangulo(double ancho, double alto) : base(ancho, alto)
            {
            }

            public override double Area()
            {
                return valor_x * valor_y / 2;
            }

            public override string ToString()
            {
                return string.Format("Triangulo [{0}x{1}, {2} m2]", Ancho, Largo, Area());
            }
        }

        public class Circulo : IFigura
        {
            protected double radio;

            public Circulo(double radio)
            {
                this.radio = radio;
            }

            public double Ancho
            {
                get { return 2 * Radio; }
                set { Radio = value / 2; }
            }

            public double Largo
            {
                get { return 2 * Radio; }
                set { Radio = value / 2; }
            }

            public virtual double Radio
            {
                get { return radio; }
                set { radio = value; }
            }

            public double Area()
            {
                return Math.PI * radio * radio;
            }

            public override string ToString()
            {
                return string.Format("Circulo [{0}, {1} m2]", Radio, Area());
            }
        }
    }
}
