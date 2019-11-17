using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App4.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
    }
}
