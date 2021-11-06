using AguiarPay.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Data.Mappings
{
    public class PedidoIndividualMapping : IEntityTypeConfiguration<PedidoIndividual>
    {
        public void Configure(EntityTypeBuilder<PedidoIndividual> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(p => p.Produtos).WithOne(p => p.PedidoIndividual).HasForeignKey(p => p.PedidoIndividualId);

            builder.ToTable("PedidosIndividuais");
        }
    }
}
