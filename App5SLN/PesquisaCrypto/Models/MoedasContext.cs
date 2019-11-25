using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.Models
{
    public class MoedasContext : DbContext
    {
        public DbSet<Moedas> Moedas { get; set; }
        public MoedasContext(DbContextOptions<MoedasContext> options) : base(options)
        {

        }
    }
}
