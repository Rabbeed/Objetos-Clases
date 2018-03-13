using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos03
{
    class Program
    {
        static void Main(string[] args)
        {
            // prueba de la clase CuentaBancaria
            CuentaBancaria cuenta = new CuentaBancaria(50.0);
            bool resultado;
            Console.WriteLine("Saldo = {0}", cuenta.Saldo);

            // deposita 80
            cuenta.Deposita(80.0);
            Console.WriteLine("Saldo = {0}", cuenta.Saldo);

            // intenta retirar mas de lo que tiene
            resultado = cuenta.Retira(150.0);

            if (resultado == false)
                Console.WriteLine("No hay suficiente saldo para retirar " + 150.0);
            Console.WriteLine("Saldo = {0}", cuenta.Saldo);

            Console.ReadLine();

        }
    }
}
