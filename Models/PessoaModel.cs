using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Venda.Model;
public class Pessoa
{
    public required string nome;
    public required string sobrenome;
    public required string dataNascimento;
    public required char sexo { get; set; }
}
