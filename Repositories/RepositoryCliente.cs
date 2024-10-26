using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Venda.Model;
using Api_Venda.Repositories.Interfaces;

namespace Api_Venda.Repositories
{
    public class RepositoryCliente : IRepositoryCliente
    {
        public IEnumerable<Cliente> BuscarClientes()
        {
            // Logica para acessar dados no banco de dados
            throw new NotImplementedException();
        }

        public int SalvarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}