using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Venda.DTOs
{
    public class ClienteDTO
    {
        public string? nome { get; set; }
        public string? TipoCliente { get; set; }// F - Físico; J- Jurídico;
        public string? CPF { get; set; }
        public string? CNPJ { get; set; }
    }
}