using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos02
{
    // la clase Punto representa un par de coordenadas X,Y
    // la clase punto herda implicitamente de la clase Object
    class Punto
    {

        // propiedades, protected para que las clases que la hereden las puedan usar
        protected int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        // propiedades
        protected int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        // Constructor por defecto sin parametros
        public Punto()
        {

        }

        // Constructor con parametros

        public Punto(int xVal, int yVal)
        {
            this.x = xVal;
            this.y = yVal;
        }


        // sobrescribimos el metodo ToString() para que haga otra cosa diferente
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

    }
}