using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos02
{
    // Hereda la clase Punto
    class Circulo : Punto
    {

        private Double radio;

        public Double Radio
        {
            get { return radio; }
            set { if (value >= 0)  radio = value; }           
              
        }

        public Circulo(){ }

        public Circulo(int xVal, int yVal, double radioVal)
        {
            this.radio = radioVal;
            base.x = xVal;
            base.y = yVal;
        }


        //metodo para calcular el Diametro
        public double calcularDiametro()
        {
            return radio * 2;
        }

        //metodo para calcular el Area
        //virtual significa que este metodo puede ser sobrecargado

        public virtual double calcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // volvemos a sobrecargar ToString()

        public override string ToString()
        {
            return "(" + x + ", " + y + ")-" + radio;
        }

        // calcula la Circunferencia del Circulo
        public double Circunferencia()
        {
            return Math.PI * calcularDiametro();
        }

    }
}
