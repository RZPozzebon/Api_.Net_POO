namespace Api_Venda.Models
{
    public class Produto
    {
        public int id { get; set; }
        public required string nomeProduto { get; set; }
        public string? tipoProduto { get; set; }
        public required double valorProduto { get; set; }
    }
}