using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos03
{
    class CuentaDeAhorros : CuentaBancaria
    {
        private double TasaDeInteres;

        public CuentaDeAhorros(double saldo, double tasa) 
            : base (saldo) // llamada explicita al constructor de la clase base
        {
            this.TasaDeInteres = tasa;
        }

    }
}
