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
        private RepositoryCliente? _repositoryCliente;

        public ServiceCliente()
        {
            _repositoryCliente = new RepositoryCliente();
        }
        public IEnumerable<Cliente> BuscarClientes()
        {
            // Chama minha camada Repositorio

            return _repositoryCliente!.BuscarClientes();

            // Implementar Logica para buscar cliente e chamar camada repository
            throw new NotImplementedException();
        }

        public int SalvarCliente(Cliente cliente)
        {
            return _repositoryCliente!.SalvarCliente(cliente);
        }
    }
}