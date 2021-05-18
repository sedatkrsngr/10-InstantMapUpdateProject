using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace InstantMapUpdateProject.API.Models
{
    public partial class UpdateMapContext : DbContext
    {
        public UpdateMapContext()
        {
        }

        public UpdateMapContext(DbContextOptions<UpdateMapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courier> Couriers { get; set; }
        public virtual DbSet<OrderFollowCoordinate> OrderFollowCoordinates { get; set; }
        public virtual DbSet<OrderFollowRoom> OrderFollowRooms { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Initial Catalog=UpdateMap;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Courier>(entity =>
            {
                entity.ToTable("Courier");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdentityNumber).HasColumnName("identityNumber");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderFollowCoordinate>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.courierLatitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.courierLongitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.RoomId).HasMaxLength(100);
            });

            modelBuilder.Entity<OrderFollowRoom>(entity =>
            {
                entity.ToTable("OrderFollowRoom");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RoomId)
                    .HasMaxLength(100)
                    .HasColumnName("roomId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
