using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App3.Models
{
    public class TarefasContexto : DbContext
    {
        public TarefasContexto(DbContextOptions<TarefasContexto> options) : base(options){ }

        public DbSet<Tarefas> Tarefas { get; set; }

    }
}
