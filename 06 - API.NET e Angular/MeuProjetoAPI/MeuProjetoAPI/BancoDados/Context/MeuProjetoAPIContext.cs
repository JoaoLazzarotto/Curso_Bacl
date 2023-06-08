using MeuProjetoAPI.BancoDados.Config;
using MeuProjetoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuProjetoAPI.BancoDados.Context
{
    public class MeuProjetoAPIContext : DbContext
    {
        public DbSet<Pessoa> TabelaPessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=DESKTOP-4RGTL07\\SQLEXPRESS;Database=MeuProjetoAPI;User Id=sa;Password=123456789;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // importar as especificações da PessoaConfig. Ex: tamanho, se é permitido tal caractere


            modelBuilder.ApplyConfiguration(new PessoaConfig());

        }
    
    }
}
