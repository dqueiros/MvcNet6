using LanchesMac.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesMac.Infra.Data.Maps
{
    public class CarrinhoCompraItemMap : IEntityTypeConfiguration<CarrinhoCompraItem>
    {
        public void Configure(EntityTypeBuilder<CarrinhoCompraItem> builder)
        {
            builder.ToTable("CarrinhoCompraItens");

            builder.HasKey(c => c.CarrinhoCompraItemId);

            builder.Property(c => c.CarrinhoCompraItemId).
                HasColumnName("CarrinhoCompraItemId")
                .UseIdentityColumn();


            builder.Property(c => c.LancheId)
                .HasColumnName("LancheId");

            builder.Property(c => c.Quantidade)
                .HasColumnName("Quantidade");

            builder.Property(c => c.CarrinhoCompraId)
                .HasColumnName("CarrinhoCompraId");

            builder.HasOne(x => x.Lanche)
                .WithMany(x => x.CarrinhoCompraItens);
        }
    }
}
