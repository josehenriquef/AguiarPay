using AguiarPay.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Data.Mappings
{
    public class ComandaColetivaMapping : IEntityTypeConfiguration<ComandaColetiva>
    {
        public void Configure(EntityTypeBuilder<ComandaColetiva> builder)
        {
            builder.HasKey(c => c.Id);

            builder.ToTable("ComandasColetivas");
        }
    }
}
