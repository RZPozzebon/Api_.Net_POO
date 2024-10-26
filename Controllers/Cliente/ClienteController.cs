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
        private ServiceCliente _clienteService;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
            _clienteService = new ServiceCliente();
        }
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            //Chama a service;
            var listaCliente = _clienteService.BuscarClientes();
            return listaCliente;
        }

        [HttpPost]
        public void Post()
        {
            
        }
    }
}