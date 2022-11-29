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
    public class OrderSubtotalConfiguration : IEntityTypeConfiguration<OrderSubtotal>
    {
        public void Configure(EntityTypeBuilder<OrderSubtotal> builder)
        {
            builder
               .HasNoKey()
               .ToView("Order Subtotals");

            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.Property(e => e.Subtotal).HasColumnType("money");
        }
    }
}
