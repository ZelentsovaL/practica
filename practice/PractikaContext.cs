using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace practice;

public partial class PractikaContext : DbContext
{
    public PractikaContext()
    {
    }

    public PractikaContext(DbContextOptions<PractikaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Operationtype> Operationtypes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Orderhistory> Orderhistories { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Paymentmethod> Paymentmethods { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productbalance> Productbalances { get; set; }

    public virtual DbSet<Statusorder> Statusorders { get; set; }

    public virtual DbSet<Typedelivery> Typedeliveries { get; set; }

    public virtual DbSet<Warehouseoperation> Warehouseoperations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Username=postgres;Password=123;Database=practika");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Idcategory).HasName("category_pkey");

            entity.ToTable("category");

            entity.Property(e => e.Idcategory)
                .ValueGeneratedNever()
                .HasColumnName("idcategory");
            entity.Property(e => e.Namecategory)
                .HasMaxLength(100)
                .HasColumnName("namecategory");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Customerid).HasName("customers_pkey");

            entity.ToTable("customers");

            entity.Property(e => e.Customerid)
                .ValueGeneratedNever()
                .HasColumnName("customerid");
            entity.Property(e => e.Contactinfo)
                .HasMaxLength(255)
                .HasColumnName("contactinfo");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Middlename)
                .HasMaxLength(50)
                .HasColumnName("middlename");
            entity.Property(e => e.Orderhistory).HasColumnName("orderhistory");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.Deliveryid).HasName("deliveries_pkey");

            entity.ToTable("deliveries");

            entity.Property(e => e.Deliveryid)
                .ValueGeneratedNever()
                .HasColumnName("deliveryid");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Courierid).HasColumnName("courierid");
            entity.Property(e => e.Deliverydate).HasColumnName("deliverydate");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.Courier).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.Courierid)
                .HasConstraintName("to_employees");

            entity.HasOne(d => d.Order).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.Orderid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_orders");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_type");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Departmentid).HasName("departments_pkey");

            entity.ToTable("departments");

            entity.Property(e => e.Departmentid)
                .ValueGeneratedNever()
                .HasColumnName("departmentid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("employees_pkey");

            entity.ToTable("employees");

            entity.Property(e => e.Employeeid)
                .ValueGeneratedNever()
                .HasColumnName("employeeid");
            entity.Property(e => e.Contactinfo)
                .HasMaxLength(255)
                .HasColumnName("contactinfo");
            entity.Property(e => e.Departmentid).HasColumnName("departmentid");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Middlename)
                .HasMaxLength(50)
                .HasColumnName("middlename");
            entity.Property(e => e.Positionid).HasColumnName("positionid");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Departmentid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_dep");

            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Positionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("123");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Idmanufacturer).HasName("manufacturer_pkey");

            entity.ToTable("manufacturer");

            entity.Property(e => e.Idmanufacturer)
                .ValueGeneratedNever()
                .HasColumnName("idmanufacturer");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Operationtype>(entity =>
        {
            entity.HasKey(e => e.Operationtypeid).HasName("operationtype_pkey");

            entity.ToTable("operationtype");

            entity.Property(e => e.Operationtypeid)
                .ValueGeneratedNever()
                .HasColumnName("operationtypeid");
            entity.Property(e => e.Nameoperation)
                .HasMaxLength(50)
                .HasColumnName("nameoperation");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Orderid).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Orderid)
                .ValueGeneratedNever()
                .HasColumnName("orderid");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Orderdate).HasColumnName("orderdate");
            entity.Property(e => e.Paymentmethod)
                .HasMaxLength(50)
                .HasColumnName("paymentmethod");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Shippingaddress)
                .HasMaxLength(255)
                .HasColumnName("shippingaddress");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Customerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_customers");

            entity.HasOne(d => d.Product).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Productid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_products");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("to_status");
        });

        modelBuilder.Entity<Orderhistory>(entity =>
        {
            entity.HasKey(e => e.Idorderhistory).HasName("orderHistory_pkey");

            entity.ToTable("orderhistory");

            entity.Property(e => e.Idorderhistory)
                .ValueGeneratedNever()
                .HasColumnName("idorderhistory");
            entity.Property(e => e.Idcustomer).HasColumnName("idcustomer");
            entity.Property(e => e.Idorder).HasColumnName("idorder");

            entity.HasOne(d => d.IdcustomerNavigation).WithMany(p => p.Orderhistories)
                .HasForeignKey(d => d.Idcustomer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_customers");

            entity.HasOne(d => d.IdorderNavigation).WithMany(p => p.Orderhistories)
                .HasForeignKey(d => d.Idorder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_order");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Paymentid).HasName("payments_pkey");

            entity.ToTable("payments");

            entity.Property(e => e.Paymentid)
                .ValueGeneratedNever()
                .HasColumnName("paymentid");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Paymentmethod).HasColumnName("paymentmethod");

            entity.HasOne(d => d.Order).WithMany(p => p.Payments)
                .HasForeignKey(d => d.Orderid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_order");

            entity.HasOne(d => d.PaymentmethodNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.Paymentmethod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_payments");
        });

        modelBuilder.Entity<Paymentmethod>(entity =>
        {
            entity.HasKey(e => e.Idpaymentmethod).HasName("paymentMethod_pkey");

            entity.ToTable("paymentmethod");

            entity.Property(e => e.Idpaymentmethod)
                .ValueGeneratedNever()
                .HasColumnName("idpaymentmethod");
            entity.Property(e => e.Namemethod)
                .HasMaxLength(50)
                .HasColumnName("namemethod");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Positionid).HasName("positions_pkey");

            entity.ToTable("positions");

            entity.Property(e => e.Positionid)
                .ValueGeneratedNever()
                .HasColumnName("positionid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Responsibilities).HasColumnName("responsibilities");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Productid).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Productid)
                .ValueGeneratedNever()
                .HasColumnName("productid");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Manufacturer).HasColumnName("manufacturer");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Warranty).HasColumnName("warranty");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_categories");

            entity.HasOne(d => d.ManufacturerNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Manufacturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_man");
        });

        modelBuilder.Entity<Productbalance>(entity =>
        {
            entity.HasKey(e => e.Balanceid).HasName("productbalances_pkey");

            entity.ToTable("productbalances");

            entity.Property(e => e.Balanceid)
                .ValueGeneratedNever()
                .HasColumnName("balanceid");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Product).WithMany(p => p.Productbalances)
                .HasForeignKey(d => d.Productid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_products");
        });

        modelBuilder.Entity<Statusorder>(entity =>
        {
            entity.HasKey(e => e.Idstatus).HasName("statusorder_pkey");

            entity.ToTable("statusorder");

            entity.Property(e => e.Idstatus)
                .ValueGeneratedNever()
                .HasColumnName("idstatus");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Typedelivery>(entity =>
        {
            entity.HasKey(e => e.Typedeliveriesid).HasName("typedeliveries_pkey");

            entity.ToTable("typedeliveries");

            entity.Property(e => e.Typedeliveriesid)
                .ValueGeneratedNever()
                .HasColumnName("typedeliveriesid");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
        });

        modelBuilder.Entity<Warehouseoperation>(entity =>
        {
            entity.HasKey(e => e.Operationid).HasName("warehouseoperations_pkey");

            entity.ToTable("warehouseoperations");

            entity.Property(e => e.Operationid)
                .ValueGeneratedNever()
                .HasColumnName("operationid");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Operationtype).HasColumnName("operationtype");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.OperationtypeNavigation).WithMany(p => p.Warehouseoperations)
                .HasForeignKey(d => d.Operationtype)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_operation");

            entity.HasOne(d => d.Product).WithMany(p => p.Warehouseoperations)
                .HasForeignKey(d => d.Productid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("to_products");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
