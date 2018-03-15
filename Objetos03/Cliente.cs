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
        private List<CuentaBancaria> cuentas;

        // constructor
        public Cliente(string nom)
        {
            this.nombre = nom;
            cuentas = new List<CuentaBancaria>();
        }

        // propiedad nombre
        public string Nombre
        {
            get { return nombre; }
        }

        // Regresa cuentas del cliente //
    
        public List<CuentaBancaria> Cuentas
        {
            get { return cuentas; }
        }

        // Agrega cuentas al arreglo
        public void AgregarCuenta(CuentaBancaria cuenta)
        {
            cuentas.Add(cuenta);
        }

    }
    
}
