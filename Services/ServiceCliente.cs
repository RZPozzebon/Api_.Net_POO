using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Venda.Model;
using Api_Venda.Repositories;
using Api_Venda.Services.Interfaces;

namespace Api_Venda.Services
{
    public class ServiceCliente : IServiceCliente
    {
        private RepositoryCliente? repositoryCliente;
        public IEnumerable<Cliente> BuscarClientes()
        {
            // Chama minha camada Repositorio
            repositoryCliente = new RepositoryCliente();
            return repositoryCliente.BuscarClientes();

            // Implementar Logica para buscar cliente e chamar camada repository
            throw new NotImplementedException();
        }
    }
}