﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OdevBir.Core.Models;
using OdevBir.DataAccess.Configurations;

namespace OdevBir.DataAccess;

public partial class NorthwndContext : DbContext
{
    public NorthwndContext()
    {
    }

    public NorthwndContext(DbContextOptions<NorthwndContext> options)
        : base(options)
    {
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public virtual DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategorySalesFor1997> CategorySalesFor1997s { get; set; }

    public virtual DbSet<CurrentProductList> CurrentProductLists { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }

    public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }

    public virtual DbSet<OrderSubtotal> OrderSubtotals { get; set; }

    public virtual DbSet<OrdersQry> OrdersQries { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductSalesFor1997> ProductSalesFor1997s { get; set; }

    public virtual DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }

    public virtual DbSet<ProductsByCategory> ProductsByCategories { get; set; }

    public virtual DbSet<QuarterlyOrder> QuarterlyOrders { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<SalesByCategory> SalesByCategories { get; set; }

    public virtual DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }

    public virtual DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlphabeticalListOfProductConfiguration());

        modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        modelBuilder.ApplyConfiguration(new CategorySalesFor1997Configuration());

        modelBuilder.ApplyConfiguration(new CurrentProductListConfiguration());

        modelBuilder.ApplyConfiguration(new CustomerConfiguration());

        modelBuilder.ApplyConfiguration(new CustomerAndSuppliersByCityConfiguration());

        modelBuilder.ApplyConfiguration(new CustomerDemographicConfiguration());

        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

        modelBuilder.ApplyConfiguration(new InvoiceConfiguration());

        modelBuilder.ApplyConfiguration(new OrderConfiguration());

        modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

        modelBuilder.ApplyConfiguration(new OrderDetailsExtendedConfiguration());

        modelBuilder.ApplyConfiguration(new OrderSubtotalConfiguration());

        modelBuilder.ApplyConfiguration(new OrdersQryConfiguration());

        modelBuilder.ApplyConfiguration(new ProductConfiguration());

        modelBuilder.ApplyConfiguration(new ProductSalesFor1997Configuration());

        modelBuilder.ApplyConfiguration(new ProductsAboveAveragePriceConfiguration());

        modelBuilder.ApplyConfiguration(new ProductsByCategoryConfiguration());

        modelBuilder.ApplyConfiguration(new QuarterlyOrderConfiguration());

        modelBuilder.ApplyConfiguration(new RegionConfiguration());

        modelBuilder.ApplyConfiguration(new SalesByCategoryConfiguration());

        modelBuilder.ApplyConfiguration(new SalesTotalsByAmountConfiguration());

        modelBuilder.ApplyConfiguration(new ShipperConfiguration());

        modelBuilder.ApplyConfiguration(new SummaryOfSalesByQuarterConfiguration());

        modelBuilder.ApplyConfiguration(new SummaryOfSalesByYearConfiguration());

        modelBuilder.ApplyConfiguration(new SupplierConfiguration());

        modelBuilder.ApplyConfiguration(new TerritoryConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }
}
