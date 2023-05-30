using MeuProjetoMVC.BancoDeDados.Configs;
using MeuProjetoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuProjetoMVC.BancoDeDados.Contexto
{
    public class BancoDeDadosContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        
        public BancoDeDadosContext()
        {
            // Cria o banco e as tebelas em 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=DESKTOP-4RGTL07\\SQLEXPRESS;Database=MeuProjetoMVC;User Id=sa;Password=123456789;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // importar um  as configs
            modelBuilder.ApplyConfiguration(new PessoaConfig());

        }

    }
}
