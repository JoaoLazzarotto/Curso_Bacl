using MeuProjetoApi.Models;
using MeuProjetoAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuProjetoAPI.BancoDados.Configs
{
    public class PrevisaoTempoConfig : IEntityTypeConfiguration<PrevisaoTempo>
    {
        public void Configure(EntityTypeBuilder<PrevisaoTempo> builder)
        {
            builder.ToTable("PrevisaoTempo");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.HasOne(p => p.Usuario)
                .WithMany(p => p.Previsoes)
                .HasForeignKey(p => p.IdUsuario);

        }
    }
}
