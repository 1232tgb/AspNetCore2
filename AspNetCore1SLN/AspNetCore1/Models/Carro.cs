using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore1.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
    }
}
