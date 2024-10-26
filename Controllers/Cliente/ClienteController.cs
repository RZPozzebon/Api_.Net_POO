using Microsoft.AspNetCore.Mvc;
using Api_Venda.Models;
using Api_Venda.Services;

namespace Api_Venda.Controllers.ClienteController
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        // Atributos
        private readonly ILogger<ClienteController> _logger;
        private ServiceCliente _clienteService;
        // Construtor
        public ClienteController(ILogger<ClienteController> logger, ServiceCliente clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        // Metodos 
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
            //var cliente = new Cliente();


            // _clienteService.SalvarCliente(cliente);
        }
    }
}