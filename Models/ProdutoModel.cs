using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Venda.Model
{
    public class Produto
    {
        public int id { get; set; }
        public required string nomeProduto { get; set; }
        public string? tipoProduto { get; set; }
        public required double valorProduto { get; set; }
    }
}