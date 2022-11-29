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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(e => e.CategoryId, "CategoriesProducts");

            builder.HasIndex(e => e.CategoryId, "CategoryID");

            builder.HasIndex(e => e.ProductName, "ProductName");

            builder.HasIndex(e => e.SupplierId, "SupplierID");

            builder.HasIndex(e => e.SupplierId, "SuppliersProducts");

            builder.Property(e => e.ProductId).HasColumnName("ProductID");
            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");
            builder.Property(e => e.ProductName).HasMaxLength(40);
            builder.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            builder.Property(e => e.ReorderLevel).HasDefaultValueSql("(0)");
            builder.Property(e => e.SupplierId).HasColumnName("SupplierID");
            builder.Property(e => e.UnitPrice)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money");
            builder.Property(e => e.UnitsInStock).HasDefaultValueSql("(0)");
            builder.Property(e => e.UnitsOnOrder).HasDefaultValueSql("(0)");

            builder.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Products_Categories");

            builder.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Products_Suppliers");

        }
    }
}
