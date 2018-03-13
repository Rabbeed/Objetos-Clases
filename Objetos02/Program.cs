using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos02
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto(72,11);

            // Punto
            Console.WriteLine("Coordenada X={0}", punto.X);
            Console.WriteLine("Coordenada Y={0}", punto.Y);

            // sobrescribimos el metodo ToString() para que haga otra cosa diferente
            Console.WriteLine("Punto = {0}", punto.ToString());

            // circulo
            Circulo circulo = new Circulo(15,7,9);
            Console.WriteLine("Circulo = {0}", circulo.ToString());
            Console.WriteLine("Diametro = {0}", circulo.calcularDiametro());
            Console.WriteLine("Area = {0}", circulo.calcularArea());

            //cilindro
            Cilindro cilindro = new Cilindro(80,2,15,30);
            Console.WriteLine("Cilindro = {0}", cilindro.ToString());
            Console.WriteLine("Area = {0}", cilindro.calcularArea());
            Console.WriteLine("Volumen = {0}", cilindro.calcularVolumen());



            Console.ReadLine();
        }
    }
}
