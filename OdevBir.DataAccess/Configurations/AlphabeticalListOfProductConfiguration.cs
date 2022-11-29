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
    public class AlphabeticalListOfProductConfiguration : IEntityTypeConfiguration<AlphabeticalListOfProduct>
    {
        public void Configure(EntityTypeBuilder<AlphabeticalListOfProduct> builder)
        {
            builder
               .HasNoKey()
               .ToView("Alphabetical list of products");

            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");
            builder.Property(e => e.CategoryName).HasMaxLength(15);
            builder.Property(e => e.ProductId).HasColumnName("ProductID");
            builder.Property(e => e.ProductName).HasMaxLength(40);
            builder.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            builder.Property(e => e.SupplierId).HasColumnName("SupplierID");
            builder.Property(e => e.UnitPrice).HasColumnType("money");
        }
    }
}
