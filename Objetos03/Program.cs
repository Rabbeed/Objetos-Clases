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
            CuentaBancaria cuenta = null;
            Cliente clientazo;

            //Crea una cuenta bancaria con saldo de 500
            Console.WriteLine("Creando al cliente Juan Perez");
            clientazo = new Cliente("Juan Perez");

            Console.WriteLine("Creando una cuenta con saldo de 4000");
            clientazo.Cuenta = new CuentaBancaria(4000);
            cuenta = clientazo.Cuenta;

            Console.WriteLine("Retiro de 2600");
            cuenta.Retira(2600);

            /*Console.WriteLine("Deposito de 1000");
            cuenta.Deposita(1000);*/

            /*Console.WriteLine("Retiro de 170");
            cuenta.Retira(170);*/

            // Imprime saldo final de la cuenta
            Console.WriteLine("Cliente [{0}] tiene un saldo de {1}",
            clientazo.Nombre, cuenta.Saldo);

            Console.ReadLine();

        }
    }
}
