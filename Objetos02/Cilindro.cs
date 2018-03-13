using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos02
{
    class Cilindro: Circulo
    {
        private double alto;

        public double Alto
        {
            get { return alto; }
            set { if (value >= 0) alto = value; }
        }

        public Cilindro()
        {

        }
        // xVal, yVal, radioVal se pasan a base(constructor circulo) para que lo agregue, y alto se queda en esta clase
        public Cilindro(int xVal, int yVal, double radioVal,
           double altoValue) : base(xVal, yVal, radioVal)
        {
            this.alto = altoValue; // establece el alto del Cilindro
        }

        // sobrescribimos el metodo Area() que ya existia en la clase circulo
        public override double calcularArea()
        {
            return 2 * base.calcularArea() + base.Circunferencia() * alto;
        }

        // metodo para calcular el volumen
        public double calcularVolumen()
        {
           return base.calcularArea() * alto;
        }

        // sobrecargamos el metodo ToString()
        public override string ToString()
        {
            return base.ToString() + "-" + alto;
        }
    }
}
