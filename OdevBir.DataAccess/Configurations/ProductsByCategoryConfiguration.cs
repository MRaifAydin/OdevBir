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
    public class ProductsByCategoryConfiguration : IEntityTypeConfiguration<ProductsByCategory>
    {
        public void Configure(EntityTypeBuilder<ProductsByCategory> builder)
        {
            builder
               .HasNoKey()
               .ToView("Products by Category");

            builder.Property(e => e.CategoryName).HasMaxLength(15);
            builder.Property(e => e.ProductName).HasMaxLength(40);
            builder.Property(e => e.QuantityPerUnit).HasMaxLength(20);
        }
    }
}
