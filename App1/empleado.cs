using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class empleado
    {
        private string nombre;
        private int edad;
        private string ctaBancaria;
        private string entidad;

        // 1er constructor
        public empleado()
        {
           
        }

        // 2do constructor
        public empleado(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        // asigna la entidad dependiendo al valor que le pasa en los primeros 4 digitos de la cuenta

        public string CuentaBancaria
        {
            set
            {
                switch (value.Substring(0, 4))
                {
                    case "1111":
                        entidad = "Banco Universal";
                        break;
                    case "2222":
                        entidad = "Banco General";
                        break;
                    case "3333":
                        entidad = "Caja Metropolitana";
                        break;
                    default:
                        entidad = "entidad sin catalogar";
                        break;
                }
            }
          
        }

        // propiedad de solo lectura
        public string EntidadBancaria
        {
            get { return entidad; }
        }

        // Metodos // 
        public DateTime Vacaciones(DateTime inicio, double dias)
        {
            // en este método calculamos el periodo de vacaciones del empleado
           DateTime final;

           return  final = inicio.AddDays(dias);

        }
    }
}
