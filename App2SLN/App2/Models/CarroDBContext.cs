using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App2.Models
{
    public partial class CarroDBContext : DbContext
    {
        public CarroDBContext()
        {
        }

        public CarroDBContext(DbContextOptions<CarroDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carros> Carros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarroDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carros>(entity =>
            {
                entity.Property(e => e.Marca).IsRequired();

                entity.Property(e => e.Nome).IsRequired();
            });
        }
    }
}
