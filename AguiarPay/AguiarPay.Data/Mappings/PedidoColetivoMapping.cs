using AguiarPay.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Data.Mappings
{
    public class PedidoColetivoMapping : IEntityTypeConfiguration<PedidoColetivo>
    {
        public void Configure(EntityTypeBuilder<PedidoColetivo> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Produto).WithMany(p => p.PedidosColetivos).HasForeignKey(f => f.ProdutoId);

            builder.ToTable("PedidosColetivos");
        }
    }
}
