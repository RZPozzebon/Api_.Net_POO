using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Venda.Model;

namespace Api_Venda.Models
{
    public class UsuarioModel : Pessoa
    {
        public int Id { get; set; }
        public required string usuario { get; set; }
        public required string senha { get; set; }
    }
}