using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar y reservar espacio
            // 1er constructor
            empleado empleado01 = new empleado();

            // 2do constructor
            empleado empleado02 = new empleado("Maria",25);

            empleado01.Nombre = "Juan Perez";
            empleado01.Edad = 35;

            // Asignando valor propiedad de solo escritura
            empleado01.CuentaBancaria = "2222-56-7779995555";
            // Obteniendo valor de propiedad solo lectura
            Console.WriteLine("Nombre del empleado es {0}, Edad {1}, Entidad {2}\n", 
                                empleado01.Nombre, 
                                empleado01.Edad,
                                empleado01.EntidadBancaria);

            // usar el metodo vacaciones
             DateTime inicio = Convert.ToDateTime("23/03/2018");
             double cantidad = 16;
             DateTime fecha = empleado01.Vacaciones(inicio, cantidad);

             Console.WriteLine("Tiene vacaciones desde {0} hasta {1}",
             inicio.ToString("dd/MMMM/yyyy"), fecha.ToString("dd/MMMM/yyyy"));

            Console.ReadLine();

        }
    }
}
