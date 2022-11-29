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
    public class ProductsAboveAveragePriceConfiguration : IEntityTypeConfiguration<ProductsAboveAveragePrice>
    {
        public void Configure(EntityTypeBuilder<ProductsAboveAveragePrice> builder)
        {
            builder
                .HasNoKey()
                .ToView("Products Above Average Price");

            builder.Property(e => e.ProductName).HasMaxLength(40);
            builder.Property(e => e.UnitPrice).HasColumnType("money");
        }
    }
}
