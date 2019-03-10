using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CAQM.Models.26FebDB
{
    public partial class carbcaq26febContext : DbContext
    {
        public carbcaq26febContext()
        {
        }

        public carbcaq26febContext(DbContextOptions<carbcaq26febContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessLevel> AccessLevel { get; set; }
        public virtual DbSet<AccessLevel1> AccessLevel1 { get; set; }
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<ActivityLog1> ActivityLog1 { get; set; }
        public virtual DbSet<AdjustmentTechnique> AdjustmentTechnique { get; set; }
        public virtual DbSet<AirDistrict> AirDistrict { get; set; }
        public virtual DbSet<AirDistrict1> AirDistrict1 { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AuditTracking> AuditTracking { get; set; }
        public virtual DbSet<AuditTracking1> AuditTracking1 { get; set; }
        public virtual DbSet<CarbDivision> CarbDivision { get; set; }
        public virtual DbSet<CarbDivision1> CarbDivision1 { get; set; }
        public virtual DbSet<Community> Community { get; set; }
        public virtual DbSet<Community1> Community1 { get; set; }
        public virtual DbSet<DataFile> DataFile { get; set; }
        public virtual DbSet<DataFileArchive> DataFileArchive { get; set; }
        public virtual DbSet<DataProvider> DataProvider { get; set; }
        public virtual DbSet<DataProvider1> DataProvider1 { get; set; }
        public virtual DbSet<DataProviderCommunity> DataProviderCommunity { get; set; }
        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<LabOrganization> LabOrganization { get; set; }
        public virtual DbSet<MeasurementData> MeasurementData { get; set; }
        public virtual DbSet<MeasurementFile> MeasurementFile { get; set; }
        public virtual DbSet<MeasurementFileArchive> MeasurementFileArchive { get; set; }
        public virtual DbSet<MeasurementStaging> MeasurementStaging { get; set; }
        public virtual DbSet<MeasurementStagingArchive> MeasurementStagingArchive { get; set; }
        public virtual DbSet<MeasurementStreamData> MeasurementStreamData { get; set; }
        public virtual DbSet<MeasurementTechnique1> MeasurementTechnique1 { get; set; }
        public virtual DbSet<MeasurementUnit1> MeasurementUnit1 { get; set; }
        public virtual DbSet<MetadataFile> MetadataFile { get; set; }
        public virtual DbSet<MetadataFileArchive> MetadataFileArchive { get; set; }
        public virtual DbSet<MetadataStaging> MetadataStaging { get; set; }
        public virtual DbSet<MetadataStagingArchive> MetadataStagingArchive { get; set; }
        public virtual DbSet<Monitor> Monitor { get; set; }
        public virtual DbSet<MonitorMfrModel> MonitorMfrModel { get; set; }
        public virtual DbSet<MonitorMfrModelParameter> MonitorMfrModelParameter { get; set; }
        public virtual DbSet<MonitorMfrModelParameterDetails> MonitorMfrModelParameterDetails { get; set; }
        public virtual DbSet<MonitorPurpose> MonitorPurpose { get; set; }
        public virtual DbSet<MonitorPurpose1> MonitorPurpose1 { get; set; }
        public virtual DbSet<MonitorStaging> MonitorStaging { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Notification1> Notification1 { get; set; }
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<Parameter1> Parameter1 { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<PhoneType1> PhoneType1 { get; set; }
        public virtual DbSet<Privilege> Privilege { get; set; }
        public virtual DbSet<Privilege1> Privilege1 { get; set; }
        public virtual DbSet<QualityFlag> QualityFlag { get; set; }
        public virtual DbSet<ReportFile> ReportFile { get; set; }
        public virtual DbSet<ReportFileType> ReportFileType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Role1> Role1 { get; set; }
        public virtual DbSet<SampleDuration> SampleDuration { get; set; }
        public virtual DbSet<SampleDuration1> SampleDuration1 { get; set; }
        public virtual DbSet<SampleFrequency> SampleFrequency { get; set; }
        public virtual DbSet<SampleQualityCode> SampleQualityCode { get; set; }
        public virtual DbSet<SampleUnit> SampleUnit { get; set; }
        public virtual DbSet<SensorStreamData> SensorStreamData { get; set; }
        public virtual DbSet<SetupMetadata> SetupMetadata { get; set; }
        public virtual DbSet<SiteLocation> SiteLocation { get; set; }
        public virtual DbSet<SiteLocationHistory> SiteLocationHistory { get; set; }
        public virtual DbSet<SiteMonitor> SiteMonitor { get; set; }
        public virtual DbSet<SiteMonitorHistory> SiteMonitorHistory { get; set; }
        public virtual DbSet<SiteMonitorParameter> SiteMonitorParameter { get; set; }
        public virtual DbSet<SiteMonitorParameter1> SiteMonitorParameter1 { get; set; }
        public virtual DbSet<SiteMonitorParameterHistory> SiteMonitorParameterHistory { get; set; }
        public virtual DbSet<SystemEventLog> SystemEventLog { get; set; }
        public virtual DbSet<SystemEventLog1> SystemEventLog1 { get; set; }
        public virtual DbSet<TimeSeriesStaging> TimeSeriesStaging { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User1> User1 { get; set; }
        public virtual DbSet<UserDataProvider> UserDataProvider { get; set; }
        public virtual DbSet<UserDocument> UserDocument { get; set; }
        public virtual DbSet<UserDocument1> UserDocument1 { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<UserType1> UserType1 { get; set; }

        // Unable to generate entity type for table 'stream.DataProviderType'. Please see the warning messages.
        // Unable to generate entity type for table 'stream.FileLoadingError'. Please see the warning messages.
        // Unable to generate entity type for table 'stream.MeasurementTechnique'. Please see the warning messages.
        // Unable to generate entity type for table 'stream.MeasurementUnit'. Please see the warning messages.
        // Unable to generate entity type for table 'stream.SiteData'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-E54HRU7\\SQLEXPRESS;Database=carbcaq.26feb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel>(entity =>
            {
                entity.ToTable("AccessLevel", "account");

                entity.Property(e => e.AccessLevelDescription)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.AccessLevelName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AccessLevel1>(entity =>
            {
                entity.HasKey(e => e.AccessLevelId);

                entity.ToTable("AccessLevel", "dev");

                entity.Property(e => e.AccessLevelDescription)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.AccessLevelName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("ActivityLog", "account");

                entity.Property(e => e.ActionType).HasMaxLength(25);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataType).HasMaxLength(25);

                entity.Property(e => e.IdNumber).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ActivityLog1>(entity =>
            {
                entity.HasKey(e => e.ActivityLogId);

                entity.ToTable("ActivityLog", "dev");

                entity.Property(e => e.ActionType).HasMaxLength(25);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataType).HasMaxLength(25);

                entity.Property(e => e.IdNumber).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityLog1)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AdjustmentTechnique>(entity =>
            {
                entity.ToTable("AdjustmentTechnique", "dev");

                entity.HasIndex(e => e.AdjustmentCode)
                    .HasName("IXU_AdjustmentTechnique_DataProviderAdjustmentCode")
                    .IsUnique();

                entity.HasIndex(e => e.DataProviderId);

                entity.Property(e => e.AdjustmentCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AdjustmentDescription).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InternalAdjustmentCodeDescription).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DataProvider)
                    .WithMany(p => p.AdjustmentTechnique)
                    .HasForeignKey(d => d.DataProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdjustmentTechnique_DataProvider");
            });

            modelBuilder.Entity<AirDistrict>(entity =>
            {
                entity.ToTable("AirDistrict", "account");

                entity.Property(e => e.AirDistrictName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AirDistrict1>(entity =>
            {
                entity.HasKey(e => e.AirDistrictId);

                entity.ToTable("AirDistrict", "dev");

                entity.Property(e => e.AirDistrictName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

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

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AuditTracking>(entity =>
            {
                entity.ToTable("AuditTracking", "stream");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentValue).HasMaxLength(4000);

                entity.Property(e => e.PreviousValue).HasMaxLength(4000);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AuditTracking1>(entity =>
            {
                entity.HasKey(e => e.AuditTrackingId);

                entity.ToTable("AuditTracking", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentValue).HasMaxLength(4000);

                entity.Property(e => e.PreviousValue).HasMaxLength(4000);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CarbDivision>(entity =>
            {
                entity.ToTable("CarbDivision", "account");

                entity.Property(e => e.CarbDivisionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CarbDivision1>(entity =>
            {
                entity.HasKey(e => e.CarbDivisionId);

                entity.ToTable("CarbDivision", "dev");

                entity.Property(e => e.CarbDivisionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.ToTable("Community", "stream");

                entity.HasIndex(e => e.CommunityName)
                    .HasName("IXU_Community_CommunityName")
                    .IsUnique();

                entity.Property(e => e.AirBasin).HasMaxLength(50);

                entity.Property(e => e.AirDistrict).HasMaxLength(50);

                entity.Property(e => e.CommunityName).HasMaxLength(255);

                entity.Property(e => e.County).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectName).HasMaxLength(255);

                entity.Property(e => e.StateName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Community1>(entity =>
            {
                entity.HasKey(e => e.CommunityId);

                entity.ToTable("Community", "dev");

                entity.HasIndex(e => e.CommunityName)
                    .HasName("IXU_Community_CommunityName")
                    .IsUnique();

                entity.Property(e => e.AirBasinName).HasMaxLength(250);

                entity.Property(e => e.AirDistrictName).HasMaxLength(250);

                entity.Property(e => e.CommunityName).HasMaxLength(250);

                entity.Property(e => e.CountyName).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataProviderCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DataFile>(entity =>
            {
                entity.ToTable("DataFile", "stream");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoadingErrors)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.SubmittedFile).IsRequired();

                entity.Property(e => e.SubmittedFileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DataFileArchive>(entity =>
            {
                entity.HasKey(e => e.DataFileId);

                entity.ToTable("DataFileArchive", "stream");

                entity.Property(e => e.DataFileId).ValueGeneratedNever();

                entity.Property(e => e.ArchivedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.SubmittedFile).IsRequired();

                entity.Property(e => e.SubmittedFileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<DataProvider>(entity =>
            {
                entity.ToTable("DataProvider", "stream");

                entity.HasIndex(e => e.DataProviderCode)
                    .HasName("IXU_DataProvider_DataProviderCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataProviderLongName).HasMaxLength(200);

                entity.Property(e => e.DataProviderShortName).HasMaxLength(50);

                entity.Property(e => e.DataProviderType).HasMaxLength(25);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DataProvider1>(entity =>
            {
                entity.HasKey(e => e.DataProviderId);

                entity.ToTable("DataProvider", "dev");

                entity.HasIndex(e => e.DataProviderCode)
                    .HasName("IXU_DataProvider_DataProviderCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataProviderCode).HasMaxLength(25);

                entity.Property(e => e.DataProviderLongName).HasMaxLength(250);

                entity.Property(e => e.DataProviderShortName).HasMaxLength(150);

                entity.Property(e => e.DataProviderType).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DataProviderCommunity>(entity =>
            {
                entity.ToTable("DataProviderCommunity", "dev");

                entity.HasIndex(e => new { e.UserDataProviderId, e.CommunityId })
                    .HasName("IXU_DataProviderCommunity")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.DataProviderCommunity)
                    .HasForeignKey(d => d.CommunityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataProviderCommunity_CommunityId");

                entity.HasOne(d => d.UserDataProvider)
                    .WithMany(p => p.DataProviderCommunity)
                    .HasForeignKey(d => d.UserDataProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataProviderCommunity_UserDataProviderId");
            });

            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.ToTable("Instrument", "stream");

                entity.HasIndex(e => new { e.Manufacturer, e.Model, e.ParameterCode })
                    .HasName("IXU_Monitor")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetectionRangeUnits).HasMaxLength(50);

                entity.Property(e => e.LowerDetectionLimit).HasMaxLength(50);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MethodDetectionLimit).HasMaxLength(50);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MonitorResolution).HasMaxLength(50);

                entity.Property(e => e.ParameterCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StandardUnitsCode).HasMaxLength(50);

                entity.Property(e => e.Uncertainty).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpperDetectionLimit).HasMaxLength(50);
            });

            modelBuilder.Entity<LabOrganization>(entity =>
            {
                entity.ToTable("LabOrganization", "dev");

                entity.HasIndex(e => e.LabOrganizationName)
                    .HasName("IXU_LabOrganization_ErrorDescription")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LabOrganizationName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MeasurementData>(entity =>
            {
                entity.HasKey(e => new { e.DataFileId, e.MeasurementDataId });

                entity.ToTable("MeasurementData", "stream");

                entity.Property(e => e.MeasurementDataId).ValueGeneratedOnAdd();

                entity.Property(e => e.ChannelAadjustedMeasurementValue)
                    .HasColumnName("ChannelAAdjustedMeasurementValue")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ChannelAmeasurementValue)
                    .HasColumnName("ChannelAMeasurementValue")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ChannelBmeasurementValue)
                    .HasColumnName("ChannelBMeasurementValue")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ChannelCadjustedMeasurementValue)
                    .HasColumnName("ChannelCAdjustedMeasurementValue")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ChannelCmeasurementValue)
                    .HasColumnName("ChannelCMeasurementValue")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ChannelDadjustedMeasurementValue)
                    .HasColumnName("ChannelDAdjustedMeasurementValue")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetectionRangeUnits).HasMaxLength(50);

                entity.Property(e => e.IsApproved).HasMaxLength(3);

                entity.Property(e => e.LabOrganization).HasMaxLength(50);

                entity.Property(e => e.MonitorId).HasMaxLength(50);

                entity.Property(e => e.SensorId).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.Uncertainty).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MeasurementFile>(entity =>
            {
                entity.ToTable("MeasurementFile", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubmittedFile).IsRequired();

                entity.Property(e => e.SubmittedFileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MeasurementFileCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MeasurementFileUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MeasurementFileArchive>(entity =>
            {
                entity.HasKey(e => e.MeasurementFileId);

                entity.ToTable("MeasurementFileArchive", "dev");

                entity.Property(e => e.MeasurementFileId).ValueGeneratedNever();

                entity.Property(e => e.ArchivedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.SubmittedFile).IsRequired();

                entity.Property(e => e.SubmittedFileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<MeasurementStaging>(entity =>
            {
                entity.HasKey(e => new { e.MeasurementFileId, e.RecordId });

                entity.ToTable("MeasurementStaging", "dev");

                entity.Property(e => e.AdjustmentTechnique).HasMaxLength(500);

                entity.Property(e => e.ChannelAadjustedMeasurementValue)
                    .HasColumnName("ChannelAAdjustedMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelAmeasurementValue)
                    .HasColumnName("ChannelAMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelBadjustedMeasurementValue)
                    .HasColumnName("ChannelBAdjustedMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelBmeasurementValue)
                    .HasColumnName("ChannelBMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelCadjustedMeasurementValue)
                    .HasColumnName("ChannelCAdjustedMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelCmeasurementValue)
                    .HasColumnName("ChannelCMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetectionRangeUnit).HasMaxLength(500);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.LabOrganization).HasMaxLength(500);

                entity.Property(e => e.MeasurementDate).HasMaxLength(500);

                entity.Property(e => e.MeasurementStartTime).HasMaxLength(500);

                entity.Property(e => e.MeasurementUnit).HasMaxLength(500);

                entity.Property(e => e.MethodDetectionLimit).HasMaxLength(500);

                entity.Property(e => e.MonitorId)
                    .HasColumnName("MonitorID")
                    .HasMaxLength(500);

                entity.Property(e => e.Parameter).HasMaxLength(500);

                entity.Property(e => e.Quality).HasMaxLength(500);

                entity.Property(e => e.RecordIsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasMaxLength(500);

                entity.Property(e => e.Uncertainty).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MeasurementStagingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MeasurementFile)
                    .WithMany(p => p.MeasurementStaging)
                    .HasForeignKey(d => d.MeasurementFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementStaging_MeasurementFileId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MeasurementStagingUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MeasurementStagingArchive>(entity =>
            {
                entity.HasKey(e => new { e.MeasurementFileId, e.RecordId });

                entity.ToTable("MeasurementStagingArchive", "dev");

                entity.Property(e => e.AdjustmentTechnique).HasMaxLength(500);

                entity.Property(e => e.ChannelAadjustedMeasurementValue)
                    .HasColumnName("ChannelAAdjustedMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelAmeasurementValue)
                    .HasColumnName("ChannelAMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelBadjustedMeasurementValue)
                    .HasColumnName("ChannelBAdjustedMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelBmeasurementValue)
                    .HasColumnName("ChannelBMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelCadjustedMeasurementValue)
                    .HasColumnName("ChannelCAdjustedMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.ChannelCmeasurementValue)
                    .HasColumnName("ChannelCMeasurementValue")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.DetectionRangeUnit).HasMaxLength(500);

                entity.Property(e => e.LabOrganization).HasMaxLength(500);

                entity.Property(e => e.MeasurementDate).HasMaxLength(500);

                entity.Property(e => e.MeasurementStartTime).HasMaxLength(500);

                entity.Property(e => e.MeasurementUnit).HasMaxLength(500);

                entity.Property(e => e.MethodDetectionLimit).HasMaxLength(500);

                entity.Property(e => e.MonitorId)
                    .HasColumnName("MonitorID")
                    .HasMaxLength(500);

                entity.Property(e => e.Parameter).HasMaxLength(500);

                entity.Property(e => e.Quality).HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasMaxLength(500);

                entity.Property(e => e.Uncertainty).HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.MeasurementFile)
                    .WithMany(p => p.MeasurementStagingArchive)
                    .HasForeignKey(d => d.MeasurementFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementStagingArchive_MeasurementFileId");
            });

            modelBuilder.Entity<MeasurementStreamData>(entity =>
            {
                entity.HasKey(e => new { e.SiteMonitorParameterId, e.MeasurementDateTime });

                entity.ToTable("MeasurementStreamData", "dev");

                entity.Property(e => e.MeasurementDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.ChannelAmeasurement).HasColumnName("ChannelAMeasurement");

                entity.Property(e => e.ChannelAmeasurementAdjusted).HasColumnName("ChannelAMeasurementAdjusted");

                entity.Property(e => e.ChannelBmeasurement).HasColumnName("ChannelBMeasurement");

                entity.Property(e => e.ChannelBmeasurementAdjusted).HasColumnName("ChannelBMeasurementAdjusted");

                entity.Property(e => e.ChannelCmeasurement).HasColumnName("ChannelCMeasurement");

                entity.Property(e => e.ChannelCmeasurementAdjusted).HasColumnName("ChannelCMeasurementAdjusted");

                entity.Property(e => e.Uncertainty).HasMaxLength(250);

                entity.HasOne(d => d.AdjustmentTechnique)
                    .WithMany(p => p.MeasurementStreamData)
                    .HasForeignKey(d => d.AdjustmentTechniqueId)
                    .HasConstraintName("FK_MeasurementStreamData_AdjustmentTechniqueId");

                entity.HasOne(d => d.DetectionRangeUnit)
                    .WithMany(p => p.MeasurementStreamDataDetectionRangeUnit)
                    .HasForeignKey(d => d.DetectionRangeUnitId)
                    .HasConstraintName("FK_MeasurementStreamData_DetectionRangeUnitId");

                entity.HasOne(d => d.LabOrganization)
                    .WithMany(p => p.MeasurementStreamData)
                    .HasForeignKey(d => d.LabOrganizationId)
                    .HasConstraintName("FK_MeasurementStreamData_LabOrganizationId");

                entity.HasOne(d => d.MeasurementFile)
                    .WithMany(p => p.MeasurementStreamData)
                    .HasForeignKey(d => d.MeasurementFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementStreamData_MeasurementFileId");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.MeasurementStreamDataMeasurementUnit)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementStreamData_MeasurementUnitId");

                entity.HasOne(d => d.QualityFlag)
                    .WithMany(p => p.MeasurementStreamData)
                    .HasForeignKey(d => d.QualityFlagId)
                    .HasConstraintName("FK_MeasurementStreamData_QualityFlagId");

                entity.HasOne(d => d.SiteMonitorParameter)
                    .WithMany(p => p.MeasurementStreamData)
                    .HasForeignKey(d => d.SiteMonitorParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementStreamData_SiteMonitorParameterId");
            });

            modelBuilder.Entity<MeasurementTechnique1>(entity =>
            {
                entity.HasKey(e => e.MeasurementTechniqueId);

                entity.ToTable("MeasurementTechnique", "dev");

                entity.HasIndex(e => new { e.ParameterCode, e.MeasurementTechniqueCode })
                    .HasName("IXU_MeasurementTechnique_ParameterCode_MeasurementTechniqueCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MeasurementTechniqueCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MeasurementTechniqueDescription).HasMaxLength(200);

                entity.Property(e => e.ParameterCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.MeasurementTechnique1)
                    .HasForeignKey(d => d.ParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeasurementTechnique_ParameterId");
            });

            modelBuilder.Entity<MeasurementUnit1>(entity =>
            {
                entity.HasKey(e => e.MeasurementUnitId);

                entity.ToTable("MeasurementUnit", "dev");

                entity.HasIndex(e => e.MeasurementUnitCode)
                    .HasName("IXU_MeasurementUnit_MeasurementUnitUnitCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MeasurementUnitAbbreviation).HasMaxLength(50);

                entity.Property(e => e.MeasurementUnitCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.MeasurementUnitDescription).HasMaxLength(150);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MetadataFile>(entity =>
            {
                entity.ToTable("MetadataFile", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubmittedFile).IsRequired();

                entity.Property(e => e.SubmittedFileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MetadataFileCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MetadataFileUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MetadataFileArchive>(entity =>
            {
                entity.HasKey(e => e.MetadataFileId);

                entity.ToTable("MetadataFileArchive", "dev");

                entity.Property(e => e.MetadataFileId).ValueGeneratedNever();

                entity.Property(e => e.ArchivedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.SubmittedFile).IsRequired();

                entity.Property(e => e.SubmittedFileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<MetadataStaging>(entity =>
            {
                entity.HasKey(e => new { e.MetadataFileId, e.RecordId });

                entity.ToTable("MetadataStaging", "dev");

                entity.Property(e => e.Cfrsiting)
                    .HasColumnName("CFRSiting")
                    .HasMaxLength(500);

                entity.Property(e => e.CommunityName).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetectionRangeUnits).HasMaxLength(500);

                entity.Property(e => e.Elevation).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasMaxLength(500);

                entity.Property(e => e.Explanation).HasMaxLength(500);

                entity.Property(e => e.FirmwareVersion).HasMaxLength(500);

                entity.Property(e => e.FlowRate).HasMaxLength(500);

                entity.Property(e => e.InletDiameter).HasMaxLength(500);

                entity.Property(e => e.InletHeight).HasMaxLength(500);

                entity.Property(e => e.InletOrientation).HasMaxLength(500);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastCalibrationTimestamp).HasMaxLength(500);

                entity.Property(e => e.LastServiceDate).HasMaxLength(500);

                entity.Property(e => e.Latitude).HasMaxLength(500);

                entity.Property(e => e.Longitude).HasMaxLength(500);

                entity.Property(e => e.LowerDetectionLimit).HasMaxLength(500);

                entity.Property(e => e.MeasurementPrecision).HasMaxLength(500);

                entity.Property(e => e.MeasurementResolution).HasMaxLength(500);

                entity.Property(e => e.MeasurementTechnique).HasMaxLength(500);

                entity.Property(e => e.MeasurementUnit).HasMaxLength(500);

                entity.Property(e => e.MethodDetectionLimit).HasMaxLength(500);

                entity.Property(e => e.MonitorId)
                    .HasColumnName("MonitorID")
                    .HasMaxLength(500);

                entity.Property(e => e.MonitorManufacturer).HasMaxLength(500);

                entity.Property(e => e.MonitorModel).HasMaxLength(500);

                entity.Property(e => e.MonitorPurchaseDate).HasMaxLength(500);

                entity.Property(e => e.MonitorPurpose).HasMaxLength(500);

                entity.Property(e => e.MonitorUncertainty).HasMaxLength(500);

                entity.Property(e => e.Parameter).HasMaxLength(500);

                entity.Property(e => e.RecordIsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.SamplingDuration).HasMaxLength(500);

                entity.Property(e => e.SamplingFrequency).HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasMaxLength(500);

                entity.Property(e => e.SiteName).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasMaxLength(500);

                entity.Property(e => e.SystemDescription).HasMaxLength(500);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpperDetectionLimit).HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MetadataStagingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MetadataFile)
                    .WithMany(p => p.MetadataStaging)
                    .HasForeignKey(d => d.MetadataFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MetadataStaging_DataFileMetadataId");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MetadataStagingUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MetadataStagingArchive>(entity =>
            {
                entity.HasKey(e => new { e.MetadataFileId, e.RecordId });

                entity.ToTable("MetadataStagingArchive", "dev");

                entity.Property(e => e.Cfrsiting)
                    .HasColumnName("CFRSiting")
                    .HasMaxLength(500);

                entity.Property(e => e.CommunityName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.DetectionRangeUnits).HasMaxLength(500);

                entity.Property(e => e.Elevation).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasMaxLength(500);

                entity.Property(e => e.Explanation).HasMaxLength(500);

                entity.Property(e => e.FirmwareVersion).HasMaxLength(500);

                entity.Property(e => e.FlowRate).HasMaxLength(500);

                entity.Property(e => e.InletDiameter).HasMaxLength(500);

                entity.Property(e => e.InletHeight).HasMaxLength(500);

                entity.Property(e => e.InletOrientation).HasMaxLength(500);

                entity.Property(e => e.LastCalibrationTimestamp).HasMaxLength(500);

                entity.Property(e => e.LastServiceDate).HasMaxLength(500);

                entity.Property(e => e.Latitude).HasMaxLength(500);

                entity.Property(e => e.Longitude).HasMaxLength(500);

                entity.Property(e => e.LowerDetectionLimit).HasMaxLength(500);

                entity.Property(e => e.MeasurementPrecision).HasMaxLength(500);

                entity.Property(e => e.MeasurementResolution).HasMaxLength(500);

                entity.Property(e => e.MeasurementTechnique).HasMaxLength(500);

                entity.Property(e => e.MeasurementUnit).HasMaxLength(500);

                entity.Property(e => e.MethodDetectionLimit).HasMaxLength(500);

                entity.Property(e => e.MonitorId)
                    .HasColumnName("MonitorID")
                    .HasMaxLength(500);

                entity.Property(e => e.MonitorManufacturer).HasMaxLength(500);

                entity.Property(e => e.MonitorModel).HasMaxLength(500);

                entity.Property(e => e.MonitorPurchaseDate).HasMaxLength(500);

                entity.Property(e => e.MonitorPurpose).HasMaxLength(500);

                entity.Property(e => e.MonitorUncertainty).HasMaxLength(500);

                entity.Property(e => e.Parameter).HasMaxLength(500);

                entity.Property(e => e.SamplingDuration).HasMaxLength(500);

                entity.Property(e => e.SamplingFrequency).HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasMaxLength(500);

                entity.Property(e => e.SiteName).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasMaxLength(500);

                entity.Property(e => e.SystemDescription).HasMaxLength(500);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.UpperDetectionLimit).HasMaxLength(500);

                entity.HasOne(d => d.MetadataFile)
                    .WithMany(p => p.MetadataStagingArchive)
                    .HasForeignKey(d => d.MetadataFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MetadataStagingArchive_DataFileMetadataId");
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.ToTable("Monitor", "stream");

                entity.Property(e => e.MonitorId).ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Cfrstring)
                    .HasColumnName("CFRString")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetectionRangeUnits).IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnName("Effective Date");

                entity.Property(e => e.Elevation).IsUnicode(false);

                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.FirmwareVersion).IsUnicode(false);

                entity.Property(e => e.FlowRate).IsUnicode(false);

                entity.Property(e => e.InletDiameter).IsUnicode(false);

                entity.Property(e => e.InletHeight).IsUnicode(false);

                entity.Property(e => e.InletOrientation).IsUnicode(false);

                entity.Property(e => e.LastCalibrationTimestamp).IsUnicode(false);

                entity.Property(e => e.LastEntryId).IsUnicode(false);

                entity.Property(e => e.LastServiceDate).IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.LowerDetectionLimit).IsUnicode(false);

                entity.Property(e => e.MeasurementResolution).IsUnicode(false);

                entity.Property(e => e.MeasurementTechnique).IsUnicode(false);

                entity.Property(e => e.MethodDetectionLimit).IsUnicode(false);

                entity.Property(e => e.MonitorManufacturer).IsUnicode(false);

                entity.Property(e => e.MonitorModel).IsUnicode(false);

                entity.Property(e => e.MonitorName).IsUnicode(false);

                entity.Property(e => e.MonitorPurchaseDate).IsUnicode(false);

                entity.Property(e => e.MonitorPurpose).IsUnicode(false);

                entity.Property(e => e.MonitorUncertainty).IsUnicode(false);

                entity.Property(e => e.Precision).IsUnicode(false);

                entity.Property(e => e.SamplingDuration).IsUnicode(false);

                entity.Property(e => e.SamplingFrequency).IsUnicode(false);

                entity.Property(e => e.SensorId)
                    .HasColumnName("SensorID")
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).IsUnicode(false);

                entity.Property(e => e.SystemDescripion).IsUnicode(false);

                entity.Property(e => e.SystemDescription).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpperDetectionLimit).IsUnicode(false);
            });

            modelBuilder.Entity<MonitorMfrModel>(entity =>
            {
                entity.ToTable("MonitorMfrModel", "dev");

                entity.HasIndex(e => new { e.MonitorManufacturer, e.MonitorModel })
                    .HasName("IXU_MonitorMfrModel_MonitorManufacturer_MonitorModel")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MonitorManufacturer).HasMaxLength(250);

                entity.Property(e => e.MonitorModel).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MonitorMfrModelParameter>(entity =>
            {
                entity.ToTable("MonitorMfrModelParameter", "dev");

                entity.HasIndex(e => e.MonitorMfrModelId);

                entity.HasIndex(e => e.ParameterId);

                entity.HasIndex(e => new { e.MonitorMfrModelId, e.ParameterId })
                    .HasName("IXU_MonitorMfrModelParameter_MonitorModel")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MonitorMfrModel)
                    .WithMany(p => p.MonitorMfrModelParameter)
                    .HasForeignKey(d => d.MonitorMfrModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonitorMfrModelParameter_MonitorMfrModelId");

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.MonitorMfrModelParameter)
                    .HasForeignKey(d => d.ParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonitorMfrModelParameter_ParameterId");
            });

            modelBuilder.Entity<MonitorMfrModelParameterDetails>(entity =>
            {
                entity.ToTable("MonitorMfrModelParameterDetails", "dev");

                entity.HasIndex(e => e.DetectionRangeUnitId);

                entity.HasIndex(e => e.MeasurementTechniqueId);

                entity.HasIndex(e => e.MeasurementUnitId);

                entity.HasIndex(e => e.MonitorMfrModelParameterId);

                entity.HasIndex(e => e.SampleDurationId);

                entity.HasIndex(e => e.SampleFrequencyId);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MonitorPrecision).HasMaxLength(250);

                entity.Property(e => e.Uncertainty).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DetectionRangeUnit)
                    .WithMany(p => p.MonitorMfrModelParameterDetailsDetectionRangeUnit)
                    .HasForeignKey(d => d.DetectionRangeUnitId)
                    .HasConstraintName("FK_SiteMonitoParameter_DetectionRangeUnitId");

                entity.HasOne(d => d.MeasurementTechnique)
                    .WithMany(p => p.MonitorMfrModelParameterDetails)
                    .HasForeignKey(d => d.MeasurementTechniqueId)
                    .HasConstraintName("FK_MonitorMfrModelParameterDetails_MeasurementTechniqueId");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.MonitorMfrModelParameterDetailsMeasurementUnit)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitoParameter_MeasurementUnitId");

                entity.HasOne(d => d.MonitorMfrModelParameter)
                    .WithMany(p => p.MonitorMfrModelParameterDetails)
                    .HasForeignKey(d => d.MonitorMfrModelParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonitorMfrModelParameterDetails_MonitorMfrModelParameterId");

                entity.HasOne(d => d.SampleDuration)
                    .WithMany(p => p.MonitorMfrModelParameterDetails)
                    .HasForeignKey(d => d.SampleDurationId)
                    .HasConstraintName("FK_MonitorMfrModelParameterDetails_SampleDurationId");

                entity.HasOne(d => d.SampleFrequency)
                    .WithMany(p => p.MonitorMfrModelParameterDetails)
                    .HasForeignKey(d => d.SampleFrequencyId)
                    .HasConstraintName("FK_MonitorMfrModelParameterDetails_SampleFrequencyId");
            });

            modelBuilder.Entity<MonitorPurpose>(entity =>
            {
                entity.ToTable("MonitorPurpose", "dev");

                entity.HasIndex(e => e.MonitorPurposeCode)
                    .HasName("IXU_MonitorPurpose_MonitorPurposeCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MonitorPurpose1)
                    .HasColumnName("MonitorPurpose")
                    .HasMaxLength(50);

                entity.Property(e => e.MonitorPurposeCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MonitorPurpose1>(entity =>
            {
                entity.HasKey(e => e.MonitorPurposeId);

                entity.ToTable("MonitorPurpose", "stream");

                entity.HasIndex(e => e.MonitorPurposeCode)
                    .HasName("IXU_MonitorPurpose_MonitorPurposeCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MonitorPurpose).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MonitorStaging>(entity =>
            {
                entity.ToTable("MonitorStaging", "stream");

                entity.HasIndex(e => new { e.MonitorName, e.Latitude, e.Longitude })
                    .HasName("IUX_MonitorStaging_MonitorName_Latitude_Longitude")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Field1).HasMaxLength(50);

                entity.Property(e => e.Field2).HasMaxLength(50);

                entity.Property(e => e.Field3).HasMaxLength(50);

                entity.Property(e => e.Field4).HasMaxLength(50);

                entity.Property(e => e.Field5).HasMaxLength(50);

                entity.Property(e => e.Field6).HasMaxLength(50);

                entity.Property(e => e.Field7).HasMaxLength(50);

                entity.Property(e => e.Field8).HasMaxLength(50);

                entity.Property(e => e.LastEntryId).HasMaxLength(50);

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.MonitorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MonitorStagingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.MonitorStagingUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Notification1>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("Notification", "account");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notification1)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Parameter>(entity =>
            {
                entity.ToTable("Parameter", "dev");

                entity.HasIndex(e => e.ParameterCode)
                    .HasName("IXU_Parameter_ParameterCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Parameter1)
                    .IsRequired()
                    .HasColumnName("Parameter")
                    .HasMaxLength(100);

                entity.Property(e => e.ParameterCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RoundOrTruncate).HasMaxLength(1);

                entity.Property(e => e.StandardUnits).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Parameter1>(entity =>
            {
                entity.HasKey(e => e.ParameterId);

                entity.ToTable("Parameter", "stream");

                entity.HasIndex(e => e.ParameterCode)
                    .HasName("IXU_Parameter_ParameterCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Parameter)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoundOrTruncate).HasMaxLength(1);

                entity.Property(e => e.StandardUnits).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.ToTable("PhoneType", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneType1)
                    .IsRequired()
                    .HasColumnName("PhoneType")
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneTypeDescription)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PhoneType1>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeId);

                entity.ToTable("PhoneType", "account");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneTypeDescription)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.ToTable("Privilege", "dev");

                entity.HasIndex(e => new { e.PrivilegeId, e.UserId })
                    .HasName("UX_Privilege_PrivilegeIdUserId")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Privilege)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Privilege1>(entity =>
            {
                entity.HasKey(e => e.PrivilegeId);

                entity.ToTable("Privilege", "account");

                entity.HasIndex(e => new { e.PrivilegeId, e.UserId })
                    .HasName("UX_Privilege_PrivilegeIdUserId")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Privilege1)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<QualityFlag>(entity =>
            {
                entity.ToTable("QualityFlag", "dev");

                entity.HasIndex(e => e.DataProviderFlag)
                    .HasName("IXU_QualityFlag_DataProviderFlag")
                    .IsUnique();

                entity.HasIndex(e => e.DataProviderId);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataProviderFlag).HasMaxLength(25);

                entity.Property(e => e.FlagDescription).HasMaxLength(100);

                entity.Property(e => e.InternalFlagDescription).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DataProvider)
                    .WithMany(p => p.QualityFlag)
                    .HasForeignKey(d => d.DataProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QualityFlag_DataProvider");
            });

            modelBuilder.Entity<ReportFile>(entity =>
            {
                entity.ToTable("ReportFile", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubmittedFile).IsRequired();

                entity.Property(e => e.SubmittedFileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ReportFileType)
                    .WithMany(p => p.ReportFile)
                    .HasForeignKey(d => d.ReportFileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportFile_ReportFileTypeId");
            });

            modelBuilder.Entity<ReportFileType>(entity =>
            {
                entity.ToTable("ReportFileType", "dev");

                entity.HasIndex(e => e.ReportFileType1)
                    .HasName("IXU_ReportFileType_ReportFileType")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportFileType1)
                    .IsRequired()
                    .HasColumnName("ReportFileType")
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "dev");

                entity.HasIndex(e => e.Role1)
                    .HasName("UX_User_Role_Role")
                    .IsUnique();

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasColumnName("Role")
                    .HasMaxLength(200);

                entity.Property(e => e.RoleDescription)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Role1>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("Role", "account");

                entity.HasIndex(e => e.Role)
                    .HasName("UX_User_Role_Role")
                    .IsUnique();

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RoleDescription)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SampleDuration>(entity =>
            {
                entity.ToTable("SampleDuration", "dev");

                entity.HasIndex(e => e.SampleDurationCode)
                    .HasName("IXU_SampleDuration_SampleDurationCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObservedOrCalculated).HasMaxLength(25);

                entity.Property(e => e.SampleDurationCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SampleDurationDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SampleDuration1>(entity =>
            {
                entity.HasKey(e => e.SampleDurationId);

                entity.ToTable("SampleDuration", "stream");

                entity.HasIndex(e => e.SampleDurationCode)
                    .HasName("IXU_SampleDuration_SampleDurationCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObservedOrCalculated).HasMaxLength(10);

                entity.Property(e => e.SampleDurationCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SampleDurationDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SampleFrequency>(entity =>
            {
                entity.ToTable("SampleFrequency", "dev");

                entity.HasIndex(e => e.SampleFrequencyCode)
                    .HasName("IXU_SampleFrequency_SampleFrequencyCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SampleFrequencyCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SampleFrequencyDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SampleQualityCode>(entity =>
            {
                entity.ToTable("SampleQualityCode", "stream");

                entity.HasIndex(e => e.SampleQualityCode1)
                    .HasName("IXU_SampleQualityCode_SampleQualityCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SampleQualityCode1).HasColumnName("SampleQualityCode");

                entity.Property(e => e.SampleQualityDescription).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SampleUnit>(entity =>
            {
                entity.ToTable("SampleUnit", "stream");

                entity.HasIndex(e => e.SampleUnitCode)
                    .HasName("IXU_Unit_UnitCode")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SampleUnitAbbreviation).HasMaxLength(50);

                entity.Property(e => e.SampleUnitCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.SampleUnitDescription).HasMaxLength(150);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SensorStreamData>(entity =>
            {
                entity.HasKey(e => e.SensorStreamData1);

                entity.ToTable("SensorStreamData", "stream");

                entity.HasIndex(e => new { e.SensorVendorId, e.SensorId })
                    .HasName("IXU_SensorVendorStreamData_SensorVendor")
                    .IsUnique();

                entity.Property(e => e.SensorStreamData1).HasColumnName("SensorStreamData");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.SensorName).HasMaxLength(150);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SetupMetadata>(entity =>
            {
                entity.HasKey(e => new { e.DataFileId, e.SetupMetadataId });

                entity.ToTable("SetupMetadata", "stream");

                entity.Property(e => e.SetupMetadataId).ValueGeneratedOnAdd();

                entity.Property(e => e.Cfrsiting).HasColumnName("CFRSiting");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetectionRangeUnits).HasMaxLength(50);

                entity.Property(e => e.Explanation).HasMaxLength(4000);

                entity.Property(e => e.FirmwareVersion).HasMaxLength(50);

                entity.Property(e => e.FlowRate).HasMaxLength(50);

                entity.Property(e => e.IsApproved).HasMaxLength(3);

                entity.Property(e => e.LastCalibrationTimestamp).HasColumnType("datetime2(0)");

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.MeasurementTechnique).HasMaxLength(50);

                entity.Property(e => e.MonitorModel).HasMaxLength(250);

                entity.Property(e => e.MonitorPrecision).HasMaxLength(50);

                entity.Property(e => e.MonitorUncertainty).HasMaxLength(50);

                entity.Property(e => e.SamplingFrequency).HasMaxLength(50);

                entity.Property(e => e.SensorId).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SiteName).HasMaxLength(250);

                entity.Property(e => e.SystemDescription).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK_SetupAndMetadata_Community_CommunityId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DataFile)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.DataFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetupAndMetadata_TransactionType_DataFileId");

                entity.HasOne(d => d.DataProvider)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.DataProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetupAndMetadata_DataProvider_DataProviderId");

                entity.HasOne(d => d.Instrument)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.InstrumentId)
                    .HasConstraintName("FK_SetupAndMetadata_Instrument_InstrumentId");

                entity.HasOne(d => d.MonitorPurpose)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.MonitorPurposeId)
                    .HasConstraintName("FK_SetupAndMetadata_MonitorPurpose_MonitorPurposeId");

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.ParameterId)
                    .HasConstraintName("FK_SetupAndMetadata_Parameter_ParameterId");

                entity.HasOne(d => d.SampleDuration)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.SampleDurationId)
                    .HasConstraintName("FK_SetupAndMetadata_SampleDuration_SampleDurationId");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.SetupMetadata)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("FK_SetupAndMetadata_TransactionType_TransactionTypeIde");
            });

            modelBuilder.Entity<SiteLocation>(entity =>
            {
                entity.ToTable("SiteLocation", "dev");

                entity.HasIndex(e => e.CarbassignedSiteCode)
                    .HasName("IXU_SiteLocation_CARBAssignedSiteCode")
                    .IsUnique();

                entity.HasIndex(e => e.CommunityId);

                entity.Property(e => e.CarbassignedSiteCode)
                    .IsRequired()
                    .HasColumnName("CARBAssignedSiteCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataProviderAssignedSiteCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Elevation).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.SiteName).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.SiteLocation)
                    .HasForeignKey(d => d.CommunityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteLocation_CommunityId");
            });

            modelBuilder.Entity<SiteLocationHistory>(entity =>
            {
                entity.ToTable("SiteLocationHistory", "dev");

                entity.HasIndex(e => e.SiteLocationId);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Explanation).HasMaxLength(4000);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewDataProviderAssignedSiteCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NewElevation).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.NewLatitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.NewLongitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.NewSiteName).HasMaxLength(250);

                entity.Property(e => e.OriginalDataProviderAssignedSiteCode)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OriginalElevation).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.OriginalLatitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.OriginalLongitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.OriginalSiteName).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SiteLocation)
                    .WithMany(p => p.SiteLocationHistory)
                    .HasForeignKey(d => d.SiteLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteLocationHistory_SiteLocationId");
            });

            modelBuilder.Entity<SiteMonitor>(entity =>
            {
                entity.ToTable("SiteMonitor", "dev");

                entity.HasIndex(e => e.DataProviderAssignedMonitorCode)
                    .HasName("IXU_SiteMonitor_DataProviderAssignedMonitorCode")
                    .IsUnique();

                entity.HasIndex(e => e.MonitorPurposeId);

                entity.HasIndex(e => e.SiteLocationId);

                entity.HasIndex(e => new { e.SiteLocationId, e.DataProviderAssignedMonitorCode })
                    .HasName("IXU_SiteMonitor")
                    .IsUnique();

                entity.Property(e => e.Cfrsiting).HasColumnName("CFRSiting");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataProviderAssignedMonitorCode).HasMaxLength(250);

                entity.Property(e => e.FirmwareVersion).HasMaxLength(50);

                entity.Property(e => e.FlowRate).HasMaxLength(50);

                entity.Property(e => e.LastServiceDate).HasColumnType("date");

                entity.Property(e => e.MonitorPurchaseDate).HasColumnType("date");

                entity.Property(e => e.SystemDescription).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MonitorMfrModel)
                    .WithMany(p => p.SiteMonitor)
                    .HasForeignKey(d => d.MonitorMfrModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitor_MonitorMfrModelId");

                entity.HasOne(d => d.MonitorPurpose)
                    .WithMany(p => p.SiteMonitor)
                    .HasForeignKey(d => d.MonitorPurposeId)
                    .HasConstraintName("FK_SiteMonitor_MonitorPurposeId");

                entity.HasOne(d => d.SiteLocation)
                    .WithMany(p => p.SiteMonitor)
                    .HasForeignKey(d => d.SiteLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitor_SiteLocationId");
            });

            modelBuilder.Entity<SiteMonitorHistory>(entity =>
            {
                entity.ToTable("SiteMonitorHistory", "dev");

                entity.HasIndex(e => e.SiteMonitorId);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Explanation).HasMaxLength(4000);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewCfrsiting).HasColumnName("NewCFRSiting");

                entity.Property(e => e.NewDataProviderAssignedMonitorCode).HasMaxLength(250);

                entity.Property(e => e.NewFirmwareVersion).HasMaxLength(50);

                entity.Property(e => e.NewFlowRate).HasMaxLength(50);

                entity.Property(e => e.NewLastServiceDate).HasColumnType("date");

                entity.Property(e => e.NewMonitorPurchaseDate).HasColumnType("date");

                entity.Property(e => e.NewSystemDescription).HasMaxLength(500);

                entity.Property(e => e.OriginalCfrsiting).HasColumnName("OriginalCFRSiting");

                entity.Property(e => e.OriginalDataProviderAssignedMonitorCode).HasMaxLength(250);

                entity.Property(e => e.OriginalFirmwareVersion).HasMaxLength(50);

                entity.Property(e => e.OriginalFlowRate).HasMaxLength(50);

                entity.Property(e => e.OriginalLastServiceDate).HasColumnType("date");

                entity.Property(e => e.OriginalMonitorPurchaseDate).HasColumnType("date");

                entity.Property(e => e.OriginalSystemDescription).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SiteMonitor)
                    .WithMany(p => p.SiteMonitorHistory)
                    .HasForeignKey(d => d.SiteMonitorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitorHistory_SiteMonitorId");
            });

            modelBuilder.Entity<SiteMonitorParameter>(entity =>
            {
                entity.ToTable("SiteMonitorParameter", "dev");

                entity.HasIndex(e => e.DetectionRangeUnitId);

                entity.HasIndex(e => e.MeasurementTechniqueId);

                entity.HasIndex(e => e.MeasurementUnitId);

                entity.HasIndex(e => e.ParameterId);

                entity.HasIndex(e => e.SampleDurationId);

                entity.HasIndex(e => e.SampleFrequencyId);

                entity.HasIndex(e => e.SiteMonitorId);

                entity.HasIndex(e => new { e.SiteMonitorId, e.ParameterId })
                    .HasName("IXU_SiteMonitorParameter")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastCalibrationTimestamp).HasColumnType("datetime2(0)");

                entity.Property(e => e.MonitorPrecision).HasMaxLength(250);

                entity.Property(e => e.MonitorUncertainty).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DetectionRangeUnit)
                    .WithMany(p => p.SiteMonitorParameterDetectionRangeUnit)
                    .HasForeignKey(d => d.DetectionRangeUnitId)
                    .HasConstraintName("FK_SiteMonitorParameter_DetectionRangeUnitId");

                entity.HasOne(d => d.MeasurementTechnique)
                    .WithMany(p => p.SiteMonitorParameter)
                    .HasForeignKey(d => d.MeasurementTechniqueId)
                    .HasConstraintName("FK_SiteMonitorParameter_MeasurementTechniqueId");

                entity.HasOne(d => d.MeasurementUnit)
                    .WithMany(p => p.SiteMonitorParameterMeasurementUnit)
                    .HasForeignKey(d => d.MeasurementUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitoParameter_SampleUnitId");

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.SiteMonitorParameter)
                    .HasForeignKey(d => d.ParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitorParameter_ParameterId");

                entity.HasOne(d => d.SampleDuration)
                    .WithMany(p => p.SiteMonitorParameter)
                    .HasForeignKey(d => d.SampleDurationId)
                    .HasConstraintName("FK_SiteMonitorParameter_SampleDurationId");

                entity.HasOne(d => d.SampleFrequency)
                    .WithMany(p => p.SiteMonitorParameter)
                    .HasForeignKey(d => d.SampleFrequencyId)
                    .HasConstraintName("FK_SiteMonitorParameter_SampleFrequencyId");

                entity.HasOne(d => d.SiteMonitor)
                    .WithMany(p => p.SiteMonitorParameter)
                    .HasForeignKey(d => d.SiteMonitorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitorParameter_SiteMonitorId");
            });

            modelBuilder.Entity<SiteMonitorParameter1>(entity =>
            {
                entity.HasKey(e => e.SiteMonitorParameterId);

                entity.ToTable("SiteMonitorParameter", "stream");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SiteMonitorParameterHistory>(entity =>
            {
                entity.ToTable("SiteMonitorParameterHistory", "dev");

                entity.HasIndex(e => e.SiteMonitorParameterId);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Explanation).HasMaxLength(4000);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewLastCalibrationTimestamp).HasColumnType("datetime2(0)");

                entity.Property(e => e.NewMonitorPrecision).HasMaxLength(250);

                entity.Property(e => e.NewMonitorUncertainty).HasMaxLength(250);

                entity.Property(e => e.OriginalLastCalibrationTimestamp).HasColumnType("datetime2(0)");

                entity.Property(e => e.OriginalMonitorPrecision).HasMaxLength(250);

                entity.Property(e => e.OriginalMonitorUncertainty).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SiteMonitorParameter)
                    .WithMany(p => p.SiteMonitorParameterHistory)
                    .HasForeignKey(d => d.SiteMonitorParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteMonitorParameterHistory_SiteMonitorParameterId");
            });

            modelBuilder.Entity<SystemEventLog>(entity =>
            {
                entity.ToTable("SystemEventLog", "dev");

                entity.Property(e => e.EventMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SystemEventLog1>(entity =>
            {
                entity.HasKey(e => e.SystemEventLogId);

                entity.ToTable("SystemEventLog");

                entity.Property(e => e.EventMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimeSeriesStaging>(entity =>
            {
                entity.ToTable("TimeSeriesStaging", "stream");

                entity.HasIndex(e => e.MonitorStagingId);

                entity.HasIndex(e => new { e.TimeSeriesStagingId, e.MonitorStagingId })
                    .HasName("IXU_TimeSeriesStaging_TimeSeriesStagingId_MonitorId")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Field1).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Field2).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Field3).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Field4).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Field5).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Field6).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Field7).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Field8).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TimeSeriesStagingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MonitorStaging)
                    .WithMany(p => p.TimeSeriesStaging)
                    .HasForeignKey(d => d.MonitorStagingId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TimeSeriesStagingUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType", "stream");

                entity.HasIndex(e => e.TransactionTypeCode)
                    .HasName("IXU_TransactionType_TransactionType")
                    .IsUnique();

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransactionTypeCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.TransactionTypeDefinition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Rationale).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AccessLevelId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.AirDistrict)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AirDistrictId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.CarbDivision)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CarbDivisionId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_User_PhoneType_PhoneType");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_Role_UserRoleId");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<User1>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("User", "account");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Rationale).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.User1)
                    .HasForeignKey(d => d.AccessLevelId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.AirDistrict)
                    .WithMany(p => p.User1)
                    .HasForeignKey(d => d.AirDistrictId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.CarbDivision)
                    .WithMany(p => p.User1)
                    .HasForeignKey(d => d.CarbDivisionId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.User1)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_User_PhoneType_PhoneType");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User1)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_Role_UserRoleId");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User1)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserDataProvider>(entity =>
            {
                entity.ToTable("UserDataProvider", "dev");

                entity.HasIndex(e => new { e.UserId, e.DataProviderId })
                    .HasName("IXU_UserDataProvider")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DataProvider)
                    .WithMany(p => p.UserDataProvider)
                    .HasForeignKey(d => d.DataProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDataProvider_DataProviderId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDataProvider)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDataProvider_UserId");
            });

            modelBuilder.Entity<UserDocument>(entity =>
            {
                entity.ToTable("UserDocument", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserDocument1>(entity =>
            {
                entity.HasKey(e => e.UserDocumentId);

                entity.ToTable("UserDocument", "account");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDocument1)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType", "dev");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserType1>(entity =>
            {
                entity.HasKey(e => e.UserTypeId);

                entity.ToTable("UserType", "account");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
