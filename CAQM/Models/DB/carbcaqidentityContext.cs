using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CAQM.Models.DB
{
    public partial class carbcaqidentityContext : DbContext
    {
        public carbcaqidentityContext()
        {
        }

        public carbcaqidentityContext(DbContextOptions<carbcaqidentityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Monitor> Monitor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7TLGQLE\\SQLEXPRESS;Database=carbcaq;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.ToTable("Monitor", "stream");

                entity.HasIndex(e => new { e.MonitorName, e.Latitude, e.Longitude })
                    .HasName("IUX_Monitor_MonitorName_Latitude_Longitude")
                    .IsUnique();

                entity.Property(e => e.Cfrstring)
                    .HasColumnName("CFRString")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetectionRangeUnits).HasMaxLength(10);

                entity.Property(e => e.EffectiveDate).HasColumnName("Effective Date");

                entity.Property(e => e.Elevation).HasMaxLength(10);

                entity.Property(e => e.Explanation).HasMaxLength(10);

                //entity.Property(e => e.Field1).HasMaxLength(50);

                //entity.Property(e => e.Field2).HasMaxLength(50);

                //entity.Property(e => e.Field3).HasMaxLength(50);

                //entity.Property(e => e.Field4).HasMaxLength(50);

                //entity.Property(e => e.Field5).HasMaxLength(50);

                //entity.Property(e => e.Field6).HasMaxLength(50);

                //entity.Property(e => e.Field7).HasMaxLength(50);

                //entity.Property(e => e.Field8).HasMaxLength(50);

                entity.Property(e => e.FirmwareVersion).HasMaxLength(10);

                entity.Property(e => e.FlowRate).HasMaxLength(10);

                entity.Property(e => e.InletDiameter).HasMaxLength(10);

                entity.Property(e => e.InletHeight).HasMaxLength(10);

                entity.Property(e => e.InletOrientation).HasMaxLength(10);

                entity.Property(e => e.LastCalibrationTimestamp).HasMaxLength(10);

                entity.Property(e => e.LastEntryId).HasMaxLength(50);

                entity.Property(e => e.LastServiceDate).HasMaxLength(10);

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.LowerDetectionLimit).HasMaxLength(10);

                entity.Property(e => e.MeasurementResolution).HasMaxLength(10);

                entity.Property(e => e.MeasurementTechnique).HasMaxLength(10);

                entity.Property(e => e.MethodDetectionLimit).HasMaxLength(10);

                entity.Property(e => e.MonitorManufacturer).HasMaxLength(10);

                entity.Property(e => e.MonitorModel).HasMaxLength(10);

                entity.Property(e => e.MonitorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MonitorPurchaseDate).HasMaxLength(10);

                entity.Property(e => e.MonitorPurpose).HasMaxLength(10);

                entity.Property(e => e.MonitorUncertainty).HasMaxLength(10);

                entity.Property(e => e.Parameter).HasMaxLength(10);

                entity.Property(e => e.Precision).HasMaxLength(10);

                entity.Property(e => e.SamplingDuration).HasMaxLength(10);

                entity.Property(e => e.SamplingFrequency).HasMaxLength(10);

                entity.Property(e => e.SensorId)
                    .HasColumnName("SensorID")
                    .HasMaxLength(10);

                entity.Property(e => e.SiteId).HasMaxLength(10);

                entity.Property(e => e.SystemDescription).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpperDetectionLimit).HasMaxLength(10);
            });
        }
    }
}
