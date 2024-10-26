using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Venda.Migrations.Data;
using Api_Venda.Models;
using Api_Venda.Repositories.Interfaces;

namespace Api_Venda.Repositories
{
    public class RepositoryCliente : IRepositoryCliente
    {
        private readonly ApplicationDbContext? _context;

        public RepositoryCliente(ApplicationDbContext? context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> BuscarClientes()
        {
            try
            {
                return _context!.Cliente.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }



        }

        public int SalvarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}