using System.ComponentModel.DataAnnotations;

namespace Api_Venda.Models
{
    public class User : Pessoa
    {
        [Key]
        public int Id { get; set; }
        public required string usuario { get; set; }
        public required string senha { get; set; }
    }
}