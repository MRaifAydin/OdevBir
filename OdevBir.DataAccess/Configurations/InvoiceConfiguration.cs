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
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder
             .HasNoKey()
             .ToView("Invoices");

            builder.Property(e => e.Address).HasMaxLength(60);
            builder.Property(e => e.City).HasMaxLength(15);
            builder.Property(e => e.Country).HasMaxLength(15);
            builder.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            builder.Property(e => e.CustomerName).HasMaxLength(40);
            builder.Property(e => e.ExtendedPrice).HasColumnType("money");
            builder.Property(e => e.Freight).HasColumnType("money");
            builder.Property(e => e.OrderDate).HasColumnType("datetime");
            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.Property(e => e.PostalCode).HasMaxLength(10);
            builder.Property(e => e.ProductId).HasColumnName("ProductID");
            builder.Property(e => e.ProductName).HasMaxLength(40);
            builder.Property(e => e.Region).HasMaxLength(15);
            builder.Property(e => e.RequiredDate).HasColumnType("datetime");
            builder.Property(e => e.Salesperson).HasMaxLength(31);
            builder.Property(e => e.ShipAddress).HasMaxLength(60);
            builder.Property(e => e.ShipCity).HasMaxLength(15);
            builder.Property(e => e.ShipCountry).HasMaxLength(15);
            builder.Property(e => e.ShipName).HasMaxLength(40);
            builder.Property(e => e.ShipPostalCode).HasMaxLength(10);
            builder.Property(e => e.ShipRegion).HasMaxLength(15);
            builder.Property(e => e.ShippedDate).HasColumnType("datetime");
            builder.Property(e => e.ShipperName).HasMaxLength(40);
            builder.Property(e => e.UnitPrice).HasColumnType("money");
        }
    }
}
