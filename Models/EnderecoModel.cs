namespace Api_Venda.Models
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