using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos03
{
    class CuentaDeCheques : CuentaBancaria
    {
        private double proteccionSobregiro;

        public CuentaDeCheques(double saldo, double sobregiro)
            : base (saldo)
        {
            this.proteccionSobregiro = sobregiro;
        }

        // sobrecarga del metodo Retira() para evitar sobregiro
        public override bool Retira(double cantidad)
        {
            bool resultado = true;
            if (cantidad > saldo)
            {
                double proteccionRequerida = cantidad - saldo;
                if (proteccionSobregiro < proteccionRequerida)
                    return false;
                else
                {
                    saldo = 0.0;
                    proteccionSobregiro -= proteccionRequerida;
                }
            }
            else
            {
                saldo -= cantidad;
                return true;
            }
            return resultado;
        }
    }
}
