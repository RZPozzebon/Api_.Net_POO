using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Venda.Model;

namespace Api_Venda.Services.Interfaces
{
    public interface IServiceCliente
    {
        IEnumerable<Cliente> BuscarClientes();
    }
}