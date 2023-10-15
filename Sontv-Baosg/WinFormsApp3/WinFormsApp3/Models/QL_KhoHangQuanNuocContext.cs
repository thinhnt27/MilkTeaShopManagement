using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WinFormsApp3.Models
{
    public partial class QL_KhoHangQuanNuocContext : DbContext
    {
        public QL_KhoHangQuanNuocContext()
        {
        }

        public QL_KhoHangQuanNuocContext(DbContextOptions<QL_KhoHangQuanNuocContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database= QL_KhoHangQuanNuoc;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Product");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("category");

                entity.Property(e => e.DateOutOfStock)
                    .HasColumnType("date")
                    .HasColumnName("dateOutOfStock");

                entity.Property(e => e.DateStockReceived)
                    .HasColumnType("date")
                    .HasColumnName("dateStockReceived");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .HasColumnName("note");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("productCode")
                    .IsFixedLength(true);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("productName");

                entity.Property(e => e.QuantityInStock).HasColumnName("quantityInStock");

                entity.Property(e => e.QuantitySold).HasColumnName("quantitySold");

                entity.Property(e => e.ReOrderLevel).HasColumnName("reOrderLevel");

                entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
