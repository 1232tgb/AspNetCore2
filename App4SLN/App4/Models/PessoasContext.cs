using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App4.Models
{
    public class PessoasContext : DbContext
    {

        public PessoasContext(DbContextOptions<PessoasContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
