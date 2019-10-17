using System.ComponentModel.DataAnnotations;

namespace AspNetCore1.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Nome { get; set; }
        
        public int Ano { get; set; }
    }
}
