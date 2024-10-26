namespace Api_Venda.Models;
public class Cliente : Pessoa
{
    public int id { get; set; }
    public string? TipoCliente { get; set; }// F - Físico; J- Jurídico;
    public string? CPF { get; set; }
    public string? CNPJ { get; set; }
    public string? email { get; set; }
    public string? telefone { get; set; }
    public Endereco? endereco { get; set; }
}
