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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasIndex(e => e.CustomerId, "CustomerID");

            builder.HasIndex(e => e.CustomerId, "CustomersOrders");

            builder.HasIndex(e => e.EmployeeId, "EmployeeID");

            builder.HasIndex(e => e.EmployeeId, "EmployeesOrders");

            builder.HasIndex(e => e.OrderDate, "OrderDate");

            builder.HasIndex(e => e.ShipPostalCode, "ShipPostalCode");

            builder.HasIndex(e => e.ShippedDate, "ShippedDate");

            builder.HasIndex(e => e.ShipVia, "ShippersOrders");

            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            builder.Property(e => e.Freight)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money");
            builder.Property(e => e.OrderDate).HasColumnType("datetime");
            builder.Property(e => e.RequiredDate).HasColumnType("datetime");
            builder.Property(e => e.ShipAddress).HasMaxLength(60);
            builder.Property(e => e.ShipCity).HasMaxLength(15);
            builder.Property(e => e.ShipCountry).HasMaxLength(15);
            builder.Property(e => e.ShipName).HasMaxLength(40);
            builder.Property(e => e.ShipPostalCode).HasMaxLength(10);
            builder.Property(e => e.ShipRegion).HasMaxLength(15);
            builder.Property(e => e.ShippedDate).HasColumnType("datetime");

            builder.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Orders_Customers");

            builder.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Orders_Employees");

            builder.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_Orders_Shippers");

        }
    }
}
