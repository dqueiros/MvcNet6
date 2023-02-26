using LanchesMac.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Infra.Data.Maps
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(c => c.CategoriaId);

            builder.Property(c => c.CategoriaId).
                HasColumnName("CategoriaId")
                .UseIdentityColumn();

            builder.Property(c => c.CategoriaNome)
                .HasColumnName("CategoriaNome");

            builder.Property(c => c.Descriçao)
                .HasColumnName("Descricao");

            builder.HasMany(c => c.Lanches)
                .WithOne(p => p.Categoria)
                .HasForeignKey(c => c.CategoriaId);
        }
    }
}
