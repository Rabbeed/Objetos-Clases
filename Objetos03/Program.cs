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
            Banco mibanco = new Banco("BBVA");
            CuentaBancaria cta;

            //Creacion de clientes
            mibanco.AgregaCliente(new Cliente("Juan Camaney"));
            mibanco.AgregaCliente(new Cliente("Jessica Alba"));
            mibanco.AgregaCliente(new Cliente("Tony Soprano"));
            mibanco.AgregaCliente(new Cliente("Jack Bauer"));

            // agregar dinero a cada cliente
            mibanco.Clientes[0].Cuenta = new CuentaBancaria(100);
            mibanco.Clientes[1].Cuenta = new CuentaBancaria(200);
            mibanco.Clientes[2].Cuenta = new CuentaBancaria(300);
            // comparte cuenta
            mibanco.Clientes[3].Cuenta = mibanco.Clientes[1].Cuenta;

            // retiros y depositos
            mibanco.Clientes[0].Cuenta.Deposita(40);
            mibanco.Clientes[2].Cuenta.Retira(50);
            mibanco.Clientes[3].Cuenta.Deposita(100);

            Console.WriteLine("\tBanco {0}", mibanco.Nombre);
            var cn = 1;

            foreach(Cliente cli in mibanco.Clientes)
            {
                Console.WriteLine("Cliente_"+cn+": {0}, Saldo: ${1}", cli.Nombre, cli.Cuenta.Saldo);
                cn++;
            }

            Console.ReadLine();

        }
    }
}
