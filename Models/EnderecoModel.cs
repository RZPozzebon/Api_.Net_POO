using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Venda.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public int Numero { get; set; }
        public string? pontoReferencia { get; set; }
    }
}