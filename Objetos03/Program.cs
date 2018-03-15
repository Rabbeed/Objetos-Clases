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

            // Crea varios clientes y sus cuentas
            mibanco.AgregaCliente(new Cliente("Juan Camaney"));
            mibanco.Clientes[0].AgregarCuenta(new CuentaDeAhorros(500.00, 0.05));
            mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(200.00, 400.00));

            mibanco.AgregaCliente(new Cliente("Tony Soprano"));
            mibanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(200.00, 10.00));

            mibanco.AgregaCliente(new Cliente("Jessica Alba"));
            mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorros(1500.00, 0.05));
            mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(200.00, 10.00));

            mibanco.AgregaCliente(new Cliente("Jack Bauer"));
            // Jack y Jessica comparten la cuenta de cheques
            mibanco.Clientes[3].AgregarCuenta(mibanco.Clientes[2].Cuentas[1]);
            mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorros(150.00, 0.05));

            // Movimientos en las cuentas, donde 0 es de cheque y 1 de ahorro
            mibanco.Clientes[2].Cuentas[0].Retira(500); // Jessica gasta 500
            mibanco.Clientes[3].Cuentas[0].Retira(205); // Jack paga con cheques, evita el sobregiro dejando en $0

            mibanco.Clientes[0].Cuentas[0].Deposita(1500); // Juan depositó 1500



            // Reporte del Banco
            Console.WriteLine("Reporte de Clientes {0} \n\n", mibanco.Nombre);
            foreach (Cliente cli in mibanco.Clientes)
            {
                Console.WriteLine("El cliente {0} tiene las cuentas: ", cli.Nombre);

                foreach (CuentaBancaria cta in cli.Cuentas)
                {
                    Console.WriteLine("Cuenta de {0}: saldo ${1}",
                     cta is CuentaDeAhorros ? "Ahorros" : "Cheques", cta.Saldo);
                }
                Console.WriteLine();

            }

            Console.ReadLine();

        }


    }
}
