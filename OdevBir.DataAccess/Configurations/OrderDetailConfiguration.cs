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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PK_Order_Details");

            builder.ToTable("Order Details");

            builder.HasIndex(e => e.OrderId, "OrderID");

            builder.HasIndex(e => e.OrderId, "OrdersOrder_Details");

            builder.HasIndex(e => e.ProductId, "ProductID");

            builder.HasIndex(e => e.ProductId, "ProductsOrder_Details");

            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.Property(e => e.ProductId).HasColumnName("ProductID");
            builder.Property(e => e.Quantity).HasDefaultValueSql("(1)");
            builder.Property(e => e.UnitPrice).HasColumnType("money");

            builder.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Orders");

            builder.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Products");

        }
    }
}
