
using LanchesMac.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LanchesMac.Infra.Data.Maps
{
    public class LancheMap : IEntityTypeConfiguration<Lanche>
    {
        public void Configure(EntityTypeBuilder<Lanche> builder)
        {
            builder.ToTable("Lanches");

            builder.HasKey(c => c.LancheId);

            builder.Property(c => c.LancheId).
                HasColumnName("LancheId")
                .UseIdentityColumn();

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.DescricaoCurta)
                .HasColumnName("DescricaoCurta");

            builder.Property(c => c.DescricaoDetalhada)
                .HasColumnName("DescricaoDetalhada");

            builder.Property(c => c.Preco)
                .HasColumnName("Preco");

            builder.Property(c => c.ImagemUrl)
                .HasColumnName("ImagemUrl");

            builder.Property(c => c.ImagemThumbnailUrl)
                .HasColumnName("ImagemThumbnailUrl");

            builder.Property(c => c.IsLanchePreferido)
                .HasColumnName("IsLanchePreferido");

            builder.Property(c => c.EmEstoque)
                .HasColumnName("EmEstoque");

            builder.Property(c => c.CategoriaId)
                .HasColumnName("CategoriaId");

            builder.HasOne(x => x.Categoria)
                .WithMany(x => x.Lanches);

            builder.HasMany(c => c.CarrinhoCompraItens)
                .WithOne(p => p.Lanche)
                .HasForeignKey(c => c.LancheId);
        }
    }
}
