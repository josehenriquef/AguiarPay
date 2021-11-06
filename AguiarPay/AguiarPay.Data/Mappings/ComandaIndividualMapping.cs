using AguiarPay.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Data.Mappings
{
    public class ComandaIndividualMapping : IEntityTypeConfiguration<ComandaIndividual>
    {
        public void Configure(EntityTypeBuilder<ComandaIndividual> builder)
        {
            builder.HasKey(c => c.Id);

            builder.ToTable("ComandasIndividuais");
        }
    }
}
