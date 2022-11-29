using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdevBir.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.DataAccess.Configurations
{
    public class SummaryOfSalesByQuarterConfiguration : IEntityTypeConfiguration<SummaryOfSalesByQuarter>
    {
        public void Configure(EntityTypeBuilder<SummaryOfSalesByQuarter> builder)
        {
            builder
               .HasNoKey()
               .ToView("Summary of Sales by Quarter");

            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.Property(e => e.ShippedDate).HasColumnType("datetime");
            builder.Property(e => e.Subtotal).HasColumnType("money");
        }
    }
}
