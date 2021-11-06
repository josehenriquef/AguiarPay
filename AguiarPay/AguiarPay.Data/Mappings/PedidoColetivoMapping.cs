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

            builder.HasMany(p => p.Produtos).WithOne(p => p.PedidoColetivo).HasForeignKey(p => p.PedidoColetivoId);

            builder.ToTable("PedidosColetivos");
        }
    }
}
