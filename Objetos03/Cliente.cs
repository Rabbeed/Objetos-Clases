using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos03
{
    class Cliente
    {
        private string nombre;
        private CuentaBancaria cuenta;

        // constructor
        public Cliente(string nom)
        {
            this.nombre = nom;  
        }

        // propiedad
        public string Nombre
        {
            get { return nombre; }
        }

        // cuenta del cliente
        public CuentaBancaria Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }


    }
}
