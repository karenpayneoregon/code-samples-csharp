namespace NorthWindForEntityFramework6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NorthContext : DbContext
    {
        public NorthContext()
            : base("name=NorthContext")
        {
        }

        public virtual DbSet<BusinessEntityPhone> BusinessEntityPhone { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ContactDevice> ContactDevice { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhoneType>()
                .HasMany(e => e.ContactDevices)
                .WithOptional(e => e.PhoneType)
                .HasForeignKey(e => e.PhoneTypeIdentifier);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipper>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShipVia);
        }
    }
}
