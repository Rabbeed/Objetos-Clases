using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos03
{
    class Banco
    {
        private string nombre;
        private List<Cliente> clientes; // arreglo dinamico de clientes

        public Banco(string nom)
        {
            this.nombre = nom;
            clientes = new List<Cliente>(); // Reservamos memoria para el arreglo clientes
        }

        public string Nombre
        {
            get { return nombre; }
        }

        // Regresa el arreglo completo de clientes
        public List<Cliente> Clientes
        {
            get { return clientes; }
        }

        // Metodo para agregar un cliente al arreglo
        public void AgregaCliente(Cliente cl)
        {
            clientes.Add(cl);
        }

    }
}
