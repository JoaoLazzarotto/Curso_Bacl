using ExercicioExtra.BancoDeDados.Configs;
using ExercicioExtra.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtra.BancoDeDados.Context
{
    public class MeuContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public MeuContext()

        {
            // Cria o banco e as tebelas em 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=DESKTOP-4RGTL07\\SQLEXPRESS;Database=ExercicioExtra1;User Id=sa;Password=123456789;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // importar um  as configs
            modelBuilder.ApplyConfiguration(new ProdutoConfig());

        }

    }
}