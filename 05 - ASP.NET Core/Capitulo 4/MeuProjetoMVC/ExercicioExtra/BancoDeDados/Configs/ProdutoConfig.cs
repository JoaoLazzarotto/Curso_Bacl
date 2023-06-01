using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using ExercicioExtra.Modelos;

namespace ExercicioExtra.BancoDeDados.Configs
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            // definindo nome da tabela
            builder.ToTable("Produtos");


            // definindo a coluna principal (primaty key)
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .UseIdentityColumn();

            // mapeando as propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.DataValidade);

            builder.Property(x => x.PrecoCompra);

            builder.Property(x => x.PrecoVenda)
                .IsRequired();

            builder.Property(x => x.QuantidadeEstoque)
                .IsRequired();

        }
    }
}

