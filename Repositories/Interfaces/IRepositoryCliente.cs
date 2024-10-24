using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Venda.Model;

namespace Api_Venda.Repositories.Interfaces
{
    public interface IRepositoryCliente
    {
        IEnumerable<Cliente> BuscarClientes();
    }
}