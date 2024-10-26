using Api_Venda.Models;
using Api_Venda.Repositories.Interfaces;
using Api_Venda.Services.Interfaces;

namespace Api_Venda.Services
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
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
            //return _repositoryCliente.SalvarCliente(cliente);
            return 0;
        }
    }
}