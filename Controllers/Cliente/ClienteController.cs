using Microsoft.AspNetCore.Mvc;
using Api_Venda.Model;
using Api_Venda.Services;

namespace Api_Venda.Controllers.ClienteController
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private ServiceCliente clienteService;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
            clienteService = new ServiceCliente();
        }
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            //Chama a service;
            var listaCliente = clienteService.BuscarClientes();
            return listaCliente;
        }
    }
}