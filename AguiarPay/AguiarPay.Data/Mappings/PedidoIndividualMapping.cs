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

            builder.HasOne(p => p.Produto).WithMany(p => p.PedidosIndividuais).HasForeignKey(f => f.ProdutoId);

            builder.ToTable("PedidosIndividuais");
        }
    }
}
