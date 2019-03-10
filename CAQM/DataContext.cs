using Microsoft.EntityFrameworkCore;
using CAQM.Entities;

namespace CAQM
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UsersDocument> UsersDocument { get; set; }
        public DbSet<FileData> FileData { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<ActivityLog> ActivityLog { get; set; }
        public DbSet<Monitors> Monitor { get; set; }
        public DbSet<MeasurementData> MeasurementData { get; set; }
        public DbSet<SiteData> SiteData { get; set; }
        public DbSet<DataFile> DataFile { get; set; }
        public DbSet<SiteMonitorParameter> SiteMonitorParameter { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //dev
            //optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=carbcaq;User Id=liadov; Password=Boston123;");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-E54HRU7\\SQLEXPRESS;Database=carbcaq.identity;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("account");

            modelBuilder.Entity<User>(entity => { entity.ToTable("User", "account"); });
            modelBuilder.Entity<Roles>(entity => { entity.ToTable("Role", "account"); });
            modelBuilder.Entity<SiteData>(entity => { entity.ToTable("SiteData", "stream"); });
            modelBuilder.Entity<MeasurementData>(entity => { entity.ToTable("MeasurementData", "stream"); });
            modelBuilder.Entity<DataFile>(entity => { entity.ToTable("DataFile", "stream"); });
            modelBuilder.Entity<SiteMonitorParameter>(entity => { entity.ToTable("SiteMonitorParameter", "stream"); });

            modelBuilder.Entity<Monitors>(entity =>
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