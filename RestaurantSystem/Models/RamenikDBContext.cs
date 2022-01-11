using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RestaurantSystem.Models
{
    public partial class RamenikDBContext : DbContext
    {
        public RamenikDBContext()
        {
        }

        public RamenikDBContext(DbContextOptions<RamenikDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<MenuPosition> MenuPositions { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;Trusted_Connection=true; Database=RamenikDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("Customer");

                entity.Property(e => e.IdCustomer)
                    .ValueGeneratedNever()
                    .HasColumnName("idCustomer");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdOrder).HasColumnName("idOrder");

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Surname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<MenuPosition>(entity =>
            {
                entity.HasKey(e => e.IdCourse);

                entity.ToTable("MenuPosition");

                entity.Property(e => e.IdCourse)
                    .ValueGeneratedNever()
                    .HasColumnName("idCourse");

                entity.Property(e => e.CourseCost)
                    .HasColumnType("money")
                    .HasColumnName("courseCost");

                entity.Property(e => e.CourseImage)
                    .HasMaxLength(50)
                    .HasColumnName("courseImage")
                    .IsFixedLength(true);

                entity.Property(e => e.CourseName)
                    .HasMaxLength(15)
                    .HasColumnName("courseName")
                    .IsFixedLength(true);

                entity.Property(e => e.CourseType)
                    .HasMaxLength(10)
                    .HasColumnName("courseType")
                    .IsFixedLength(true);

                entity.Property(e => e.Ingredients)
                    .HasMaxLength(50)
                    .HasColumnName("ingredients")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder)
                    .ValueGeneratedNever()
                    .HasColumnName("idOrder");

                entity.Property(e => e.DeliveryCost)
                    .HasColumnType("money")
                    .HasColumnName("deliveryCost");

                entity.Property(e => e.IdSpecialOffer).HasColumnName("idSpecialOffer");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("orderDate");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("orderStatus");

                entity.Property(e => e.OrderTime)
                    .HasColumnType("datetime")
                    .HasColumnName("orderTime");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("paymentOption");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("money")
                    .HasColumnName("totalCost");
            });

            modelBuilder.Entity<SpecialOffer>(entity =>
            {
                entity.HasKey(e => e.IdSpecialOffer);

                entity.ToTable("SpecialOffer");

                entity.Property(e => e.IdSpecialOffer)
                    .ValueGeneratedNever()
                    .HasColumnName("idSpecialOffer");

                entity.Property(e => e.SpecialOfferDescription)
                    .HasMaxLength(40)
                    .HasColumnName("specialOfferDescription")
                    .IsFixedLength(true);

                entity.Property(e => e.SpecialOfferName)
                    .HasMaxLength(20)
                    .HasColumnName("specialOfferName")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
