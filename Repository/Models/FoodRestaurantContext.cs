using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Repository.Models
{
    public partial class FoodRestaurantContext : DbContext
    {
        public FoodRestaurantContext()
        {
        }

        public FoodRestaurantContext(DbContextOptions<FoodRestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<FoodTable> FoodTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private static string GetConnectionString() {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:FoodRestaurant"];
            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Account__536C85E52EC33112");

                entity.ToTable("Account");

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Kathy')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.DateCheckIn)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCheckOut).HasColumnType("date");

                entity.HasOne(d => d.IdTableNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.IdTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__Status__286302EC");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("PK__BillDeta__11F2FC6A021DDFDF");

                entity.ToTable("BillDetail");

                entity.HasOne(d => d.IdBillNavigation)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.IdBill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetai__IdBil__2C3393D0");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.IdFood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetai__IdFoo__2D27B809");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Unnamed')");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Food__Price__1FCDBCEB");
            });

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.ToTable("FoodCategory");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Unnamed')");
            });

            modelBuilder.Entity<FoodTable>(entity =>
            {
                entity.ToTable("FoodTable");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Unnamed')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Empty')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
