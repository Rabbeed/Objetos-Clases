﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos03
{
    class CuentaBancaria
    {
        // poder heredar esta propiedad
        protected double saldo;

        // constructor 
        public CuentaBancaria(double saldo)
        {
            this.saldo = saldo;
        }

        public double Saldo
        {
            get { return saldo; }
           
        }

        // depositar una cantidad
        public void Deposita(double cantidad)
        {
            saldo += cantidad;
        }

        // retira una cantidad de la cuenta, regresa false si no existe saldo suficiente, 
        // Virtual para poder sobrecargar
        public virtual bool Retira(double cantidad)
        {
            if (saldo >= cantidad)
            {
                saldo -= cantidad;
                return true ;
            }
            else return false ;
        }


    }
}
