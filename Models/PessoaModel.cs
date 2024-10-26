namespace Api_Venda.Models;
public class Pessoa
{
    public required string nome;
    public required string sobrenome;
    public required string dataNascimento;
    public required char sexo { get; set; }
}
