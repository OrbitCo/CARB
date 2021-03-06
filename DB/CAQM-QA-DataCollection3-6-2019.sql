USE [master]
GO
/****** Object:  Database [carbcaq]    Script Date: 3/6/2019 5:03:14 PM ******/
CREATE DATABASE [carbcaq]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'carbcaq', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\carbcaq.mdf' , SIZE = 82304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'carbcaq_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\carbcaq_log.ldf' , SIZE = 536512KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [carbcaq] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [carbcaq].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [carbcaq] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [carbcaq] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [carbcaq] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [carbcaq] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [carbcaq] SET ARITHABORT OFF 
GO
ALTER DATABASE [carbcaq] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [carbcaq] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [carbcaq] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [carbcaq] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [carbcaq] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [carbcaq] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [carbcaq] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [carbcaq] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [carbcaq] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [carbcaq] SET  DISABLE_BROKER 
GO
ALTER DATABASE [carbcaq] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [carbcaq] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [carbcaq] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [carbcaq] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [carbcaq] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [carbcaq] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [carbcaq] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [carbcaq] SET RECOVERY FULL 
GO
ALTER DATABASE [carbcaq] SET  MULTI_USER 
GO
ALTER DATABASE [carbcaq] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [carbcaq] SET DB_CHAINING OFF 
GO
ALTER DATABASE [carbcaq] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [carbcaq] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [carbcaq] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'carbcaq', N'ON'
GO
ALTER DATABASE [carbcaq] SET QUERY_STORE = OFF
GO
USE [carbcaq]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [carbcaq]
GO
/****** Object:  User [carbcaqdev]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE USER [carbcaqdev] FOR LOGIN [carbcaqdev] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ayang]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE USER [ayang] FOR LOGIN [ayang] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [carbcaqdev]
GO
ALTER ROLE [db_datareader] ADD MEMBER [carbcaqdev]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [carbcaqdev]
GO
/****** Object:  Schema [account]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE SCHEMA [account]
GO
/****** Object:  Schema [collection]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE SCHEMA [collection]
GO
/****** Object:  Schema [dev]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE SCHEMA [dev]
GO
/****** Object:  Schema [meta]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE SCHEMA [meta]
GO
/****** Object:  Schema [report]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE SCHEMA [report]
GO
/****** Object:  Schema [stream]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE SCHEMA [stream]
GO
/****** Object:  Schema [temp_stream]    Script Date: 3/6/2019 5:03:15 PM ******/
CREATE SCHEMA [temp_stream]
GO
/****** Object:  Table [stream].[SiteMonitor]    Script Date: 3/6/2019 5:03:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SiteMonitor](
	[SiteMonitorId] [int] IDENTITY(1,1) NOT NULL,
	[SiteLocationId] [int] NOT NULL,
	[MonitorMfrModelId] [int] NOT NULL,
	[MonitorCode] [nvarchar](250) NULL,
	[MonitorPurposeId] [int] NULL,
	[FirmwareVersion] [nvarchar](50) NULL,
	[MonitorPurchaseDate] [date] NULL,
	[LastServiceDate] [date] NULL,
	[CFRSiting] [bit] NULL,
	[FlowRate] [nvarchar](50) NULL,
	[InletHeight] [float] NULL,
	[InletOrientation] [int] NULL,
	[InletDiameter] [float] NULL,
	[SystemDescription] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SiteMonitor] PRIMARY KEY CLUSTERED 
(
	[SiteMonitorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_SiteMonitor] UNIQUE NONCLUSTERED 
(
	[SiteLocationId] ASC,
	[MonitorCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[Parameter]    Script Date: 3/6/2019 5:03:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[Parameter](
	[ParameterId] [int] IDENTITY(1,1) NOT NULL,
	[ParameterCode] [nvarchar](10) NOT NULL,
	[Parameter] [nvarchar](100) NOT NULL,
	[StandardUnits] [nvarchar](100) NULL,
	[RoundOrTruncate] [nchar](1) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Parameter] PRIMARY KEY CLUSTERED 
(
	[ParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_Parameter_ParameterCode] UNIQUE NONCLUSTERED 
(
	[ParameterCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[AirMonitoringStreamSite]    Script Date: 3/6/2019 5:03:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[AirMonitoringStreamSite](
	[AirMonitoringStreamSiteId] [int] IDENTITY(1,1) NOT NULL,
	[SiteMonitorId] [int] NOT NULL,
	[ParameterId] [int] NOT NULL,
	[StreamName] [nvarchar](250) NULL,
	[MeasurementTechniqueId] [int] NULL,
	[MeasurementUnitId] [int] NOT NULL,
	[SampleDurationId] [int] NULL,
	[SampleFrequencyId] [int] NULL,
	[DetectionRangeUnitId] [int] NULL,
	[UpperDetectionLimit] [float] NULL,
	[LowerDetectionLimit] [float] NULL,
	[MethodDetectionLimit] [float] NULL,
	[MonitorUncertainty] [nvarchar](250) NULL,
	[MonitorPrecision] [nvarchar](250) NULL,
	[MeasurementResolution] [int] NULL,
	[LastCalibrationTimestamp] [datetime2](0) NULL,
	[AllowStream] [bit] NULL,
	[DisplayStream] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_AirMonitoringStreamSite] PRIMARY KEY CLUSTERED 
(
	[AirMonitoringStreamSiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_AirMonitoringStreamSite] UNIQUE NONCLUSTERED 
(
	[SiteMonitorId] ASC,
	[ParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MonitorPurpose]    Script Date: 3/6/2019 5:03:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MonitorPurpose](
	[MonitorPurposeId] [int] IDENTITY(1,1) NOT NULL,
	[MonitorPurposeCode] [nvarchar](25) NOT NULL,
	[MonitorPurpose] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MonitorPurpose] PRIMARY KEY CLUSTERED 
(
	[MonitorPurposeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_MonitorPurpose_MonitorPurposeCode] UNIQUE NONCLUSTERED 
(
	[MonitorPurposeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[DataProvider]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[DataProvider](
	[DataProviderId] [int] IDENTITY(1,1) NOT NULL,
	[DataProviderCode] [nvarchar](25) NULL,
	[DataProviderShortName] [nvarchar](150) NULL,
	[DataProviderLongName] [nvarchar](250) NULL,
	[DataProviderType] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_DataProvider] PRIMARY KEY CLUSTERED 
(
	[DataProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_DataProvider_DataProviderCode] UNIQUE NONCLUSTERED 
(
	[DataProviderCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[Community]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[Community](
	[CommunityId] [int] IDENTITY(1,1) NOT NULL,
	[DataProviderId] [int] NOT NULL,
	[CommunityName] [nvarchar](250) NULL,
	[AirBasinName] [nvarchar](250) NULL,
	[AirDistrictName] [nvarchar](250) NULL,
	[CountyName] [nvarchar](250) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Community] PRIMARY KEY CLUSTERED 
(
	[CommunityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_Community_CommunityName] UNIQUE NONCLUSTERED 
(
	[CommunityName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[UserDataProvider]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[UserDataProvider](
	[UserDataProviderId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[DataProviderId] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_UserDataProvider] PRIMARY KEY CLUSTERED 
(
	[UserDataProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_UserDataProvider] UNIQUE NONCLUSTERED 
(
	[UserId] ASC,
	[DataProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[SiteLocation]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SiteLocation](
	[SiteLocationId] [int] IDENTITY(1,1) NOT NULL,
	[CommunityId] [int] NOT NULL,
	[CARBSiteCode] [nvarchar](250) NOT NULL,
	[UserSiteCode] [nvarchar](250) NOT NULL,
	[SiteName] [nvarchar](250) NULL,
	[Latitude] [decimal](12, 9) NOT NULL,
	[Longitude] [decimal](12, 9) NOT NULL,
	[Elevation] [decimal](9, 4) NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SiteLocation] PRIMARY KEY CLUSTERED 
(
	[SiteLocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_SiteLocation_CARBSiteCode] UNIQUE NONCLUSTERED 
(
	[CARBSiteCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementStreamData]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementStreamData](
	[MeasurementStreamDataId] [uniqueidentifier] NOT NULL,
	[MeasurementFileId] [int] NOT NULL,
	[AirMonitoringStreamSiteId] [int] NOT NULL,
	[MeasurementDate] [date] NOT NULL,
	[MeasurementTime] [time](0) NOT NULL,
	[MeasurementHourId] [int] NOT NULL,
	[MeasurementUnitId] [int] NOT NULL,
	[DetectionRangeUnitId] [int] NULL,
	[AdjustmentTechniqueId] [int] NULL,
	[QualityFlagId] [int] NULL,
	[MethodDetectionLimit] [float] NULL,
	[LabOrganizationId] [int] NULL,
	[Uncertainty] [nvarchar](250) NULL,
	[ChannelAMeasurement] [float] NOT NULL,
	[ChannelBMeasurement] [float] NULL,
	[ChannelCMeasurement] [float] NULL,
	[ChannelAMeasurementAdjusted] [float] NULL,
	[ChannelBMeasurementAdjusted] [float] NULL,
	[ChannelCMeasurementAdjusted] [float] NULL,
 CONSTRAINT [PK_MeasurementStreamData] PRIMARY KEY CLUSTERED 
(
	[AirMonitoringStreamSiteId] ASC,
	[MeasurementDate] ASC,
	[MeasurementTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MonitorMfrModel]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MonitorMfrModel](
	[MonitorMfrModelId] [int] IDENTITY(1,1) NOT NULL,
	[MonitorManufacturer] [nvarchar](250) NULL,
	[MonitorModel] [nvarchar](250) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MonitorMfrModel] PRIMARY KEY CLUSTERED 
(
	[MonitorMfrModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_MonitorMfrModel] UNIQUE NONCLUSTERED 
(
	[MonitorManufacturer] ASC,
	[MonitorModel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [stream].[MeasurementStreamDataView]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create view [stream].[MeasurementStreamDataView] as
select 
	DataProviderType
, SiteName
, Longitude
, Latitude
, MonitorCode
, MonitorPurpose
, MonitorManufacturer
, MonitorModel
, ParameterCode
, Parameter
, MeasurementDate
, [0] as Hour0000To0059AM
, [1] as Hour0100To0159AM
, [2] as Hour0200To0259AM
, [3] as Hour0300To0359AM
, [4] as Hour0400To0459AM
, [5] as Hour0500To0559AM
, [6] as Hour0600To0659AM
, [7] as Hour0700To0759AM
, [8] as Hour0800To0859AM
, [9] as Hour0900To0959AM
, [10] as Hour1000To1059AM
, [11] as Hour1100To1159AM
, [12] as Hour1200To1259PM
, [13] as Hour1300To1359PM
, [14] as Hour1400To1459PM
, [15] as Hour1500To1559PM
, [16] as Hour1600To1659PM
, [17] as Hour1700To1759PM
, [18] as Hour1800To1859PM
, [19] as Hour1900To1959PM
, [20] as Hour2000To2059PM
, [21] as Hour2100To2159PM
, [22] as Hour2200To2259PM
, [23] as Hour2300To2359PM
from 
(
select
	dp.DataProviderType
, sl.SiteName
, sl.Longitude
, sl.Latitude
, sm.MonitorCode
, mp.MonitorPurpose
, mmm.MonitorManufacturer
, mmm.MonitorModel
, p.ParameterCode
, p.Parameter
,	msd.MeasurementDate
, msd.MeasurementHourId
, msd.ChannelAMeasurement
from stream.MeasurementStreamData msd
join stream.AirMonitoringStreamSite amss
	on msd.AirMonitoringStreamSiteId = amss.AirMonitoringStreamSiteId
join stream.Parameter p
	on amss.ParameterId = p.ParameterId
join stream.SiteMonitor sm
	on amss.SiteMonitorId = sm.SiteMonitorId
join stream.MonitorMfrModel mmm
	on sm.MonitorMfrModelId = mmm.MonitorMfrModelId
join stream.MonitorPurpose mp
	on sm.MonitorPurposeId = mp.MonitorPurposeId
join stream.SiteLocation sl
	on sm.SiteLocationId = sl.SiteLocationId
join stream.Community c
	on sl.CommunityId = c.CommunityId
join stream.DataProvider dp
	on c.DataProviderId = dp.DataProviderId
join stream.UserDataProvider udp
	on dp.DataProviderId = udp.DataProviderId
) StreamData
pivot
(
	max(ChannelAMeasurement)
	for MeasurementHourId IN ([0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14]
, [15], [16], [17], [18], [19], [20], [21], [22], [23])
) MeasurementHourPivot




























GO
/****** Object:  Table [account].[AccessLevel]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[AccessLevel](
	[AccessLevelId] [int] IDENTITY(1,1) NOT NULL,
	[AccessLevelName] [nvarchar](100) NOT NULL,
	[AccessLevelDescription] [nvarchar](256) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_AccessLevel] PRIMARY KEY CLUSTERED 
(
	[AccessLevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[ActivityLog]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[ActivityLog](
	[ActivityLogId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ActionType] [nvarchar](25) NULL,
	[DataType] [nvarchar](25) NULL,
	[IdNumber] [nvarchar](100) NULL,
	[IsWrongSigninAttempt] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_ActivityLog] PRIMARY KEY CLUSTERED 
(
	[ActivityLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[AirDistrict]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[AirDistrict](
	[AirDistrictId] [int] IDENTITY(1,1) NOT NULL,
	[AirDistrictName] [nvarchar](100) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_AirDistrict] PRIMARY KEY CLUSTERED 
(
	[AirDistrictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[CarbDivision]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[CarbDivision](
	[CarbDivisionId] [int] IDENTITY(1,1) NOT NULL,
	[CarbDivisionName] [nvarchar](100) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_CarbDivision] PRIMARY KEY CLUSTERED 
(
	[CarbDivisionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[Notification]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[Notification](
	[NotificationId] [int] IDENTITY(1,1) NOT NULL,
	[NotifyByEmail] [bit] NOT NULL,
	[NotifyOnDashboard] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Notification] PRIMARY KEY CLUSTERED 
(
	[NotificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[PhoneType]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[PhoneType](
	[PhoneTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PhoneType] [nvarchar](10) NOT NULL,
	[PhoneTypeDescription] [nvarchar](100) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_PhoneType] PRIMARY KEY CLUSTERED 
(
	[PhoneTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[Privilege]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[Privilege](
	[PrivilegeId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BuildAdHocQueries] [bit] NOT NULL,
	[BuildAdHovReports] [bit] NOT NULL,
	[ConfigureAttributes] [bit] NOT NULL,
	[ConfigurePrivileges] [bit] NOT NULL,
	[ConfigureRoles] [bit] NOT NULL,
	[CreateUser] [bit] NOT NULL,
	[DeactivateReactivateUser] [bit] NOT NULL,
	[DeleteData] [bit] NOT NULL,
	[DeleteUser] [bit] NOT NULL,
	[ProvisionUserAccount] [bit] NOT NULL,
	[RunCannedQueries] [bit] NOT NULL,
	[RunCannedReports] [bit] NOT NULL,
	[SaveAdHocQueries] [bit] NOT NULL,
	[SaveAdHovReports] [bit] NOT NULL,
	[UpdateData] [bit] NOT NULL,
	[UpdateUser] [bit] NOT NULL,
	[UploadData] [bit] NOT NULL,
	[ViewAllData] [bit] NOT NULL,
	[ViewAllDataConstrained] [bit] NOT NULL,
	[ViewEmissionsData] [bit] NOT NULL,
	[ViewPublicData] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Privilege] PRIMARY KEY CLUSTERED 
(
	[PrivilegeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UX_Privilege_PrivilegeIdUserId] UNIQUE NONCLUSTERED 
(
	[PrivilegeId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[Role]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[Role](
	[RoleId] [int] NOT NULL,
	[Role] [nvarchar](200) NOT NULL,
	[RoleDescription] [nvarchar](200) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_User_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UX_User_Role_Role] UNIQUE NONCLUSTERED 
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[User]    Script Date: 3/6/2019 5:03:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[PasswordHash] [varchar](50) NULL,
	[PasswordSalt] [varchar](50) NULL,
	[Username] [nvarchar](100) NULL,
	[RoleId] [int] NOT NULL,
	[Email] [nvarchar](254) NULL,
	[Phone] [nvarchar](50) NULL,
	[PhoneTypeId] [int] NULL,
	[UserTypeId] [int] NULL,
	[AirDistrictId] [int] NULL,
	[CarbDivisionId] [int] NULL,
	[AccessLevelId] [int] NULL,
	[Rationale] [nvarchar](1000) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[UserDocument]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[UserDocument](
	[UserDocumentId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[FileName] [nvarchar](500) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_User_UserDocument] PRIMARY KEY CLUSTERED 
(
	[UserDocumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [account].[UserType]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [account].[UserType](
	[UserTypeId] [int] IDENTITY(1,1) NOT NULL,
	[UserTypeName] [nvarchar](100) NOT NULL,
	[SubType] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[UserTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemEventLog]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemEventLog](
	[SystemEventLogId] [bigint] IDENTITY(1,1) NOT NULL,
	[EventDateTime] [datetime2](7) NOT NULL,
	[EventNumber] [int] NOT NULL,
	[EventType] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[ServerName] [nvarchar](50) NOT NULL,
	[EventMessage] [nvarchar](4000) NOT NULL,
 CONSTRAINT [PK_SystemEventLogId] PRIMARY KEY CLUSTERED 
(
	[SystemEventLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [report].[ReportFile]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [report].[ReportFile](
	[ReportFileId] [int] IDENTITY(1,1) NOT NULL,
	[ReportFileTypeId] [int] NOT NULL,
	[SubmittedFileName] [nvarchar](500) NOT NULL,
	[SubmittedFile] [varbinary](max) NOT NULL,
	[FileIsValid] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_ReportFile] PRIMARY KEY CLUSTERED 
(
	[ReportFileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [report].[ReportFileType]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [report].[ReportFileType](
	[ReportFileTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ReportFileType] [nvarchar](250) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_ReportFileType] PRIMARY KEY CLUSTERED 
(
	[ReportFileTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_ReportFileType_ReportFileType] UNIQUE NONCLUSTERED 
(
	[ReportFileType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[AdjustmentTechnique]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[AdjustmentTechnique](
	[AdjustmentTechniqueId] [int] IDENTITY(1,1) NOT NULL,
	[DataProviderId] [int] NOT NULL,
	[AdjustmentCode] [nvarchar](50) NOT NULL,
	[AdjustmentDescription] [nvarchar](200) NULL,
	[InternalAdjustmentCode] [int] NULL,
	[InternalAdjustmentCodeDescription] [nvarchar](100) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_AdjustmentTechnique] PRIMARY KEY CLUSTERED 
(
	[AdjustmentTechniqueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_AdjustmentTechnique] UNIQUE NONCLUSTERED 
(
	[DataProviderId] ASC,
	[AdjustmentCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[AirMonitoringStreamSiteHistory]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[AirMonitoringStreamSiteHistory](
	[AirMonitoringStreamSiteHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[AirMonitoringStreamSiteId] [int] NOT NULL,
	[OriginalMeasurementTechniqueId] [int] NULL,
	[OriginalMeasurementUnitId] [int] NOT NULL,
	[OriginalSampleDurationId] [int] NULL,
	[OriginalSampleFrequencyId] [int] NULL,
	[OriginalDetectionRangeUnitId] [int] NULL,
	[OriginalUpperDetectionLimit] [float] NULL,
	[OriginalLowerDetectionLimit] [float] NULL,
	[OriginalMethodDetectionLimit] [float] NULL,
	[OriginalMonitorUncertainty] [nvarchar](250) NULL,
	[OriginalMonitorPrecision] [nvarchar](250) NULL,
	[OriginalMeasurementResolution] [int] NULL,
	[OriginalLastCalibrationTimestamp] [datetime2](0) NULL,
	[OriginalIsActive] [bit] NULL,
	[NewMeasurementTechniqueId] [int] NULL,
	[NewMeasurementUnitId] [int] NOT NULL,
	[NewSampleDurationId] [int] NULL,
	[NewSampleFrequencyId] [int] NULL,
	[NewDetectionRangeUnitId] [int] NULL,
	[NewUpperDetectionLimit] [float] NULL,
	[NewLowerDetectionLimit] [float] NULL,
	[NewMethodDetectionLimit] [float] NULL,
	[NewMonitorUncertainty] [nvarchar](250) NULL,
	[NewMonitorPrecision] [nvarchar](250) NULL,
	[NewMeasurementResolution] [int] NULL,
	[NewLastCalibrationTimestamp] [datetime2](0) NULL,
	[NewIsActive] [bit] NULL,
	[Explanation] [nvarchar](4000) NULL,
	[IsApproved] [bit] NULL,
	[ApprovedBy] [int] NOT NULL,
	[ApprovedDate] [datetime2](0) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_AirMonitoringStreamSiteHistory] PRIMARY KEY CLUSTERED 
(
	[AirMonitoringStreamSiteHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[AuditTracking]    Script Date: 3/6/2019 5:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[AuditTracking](
	[AuditTrackingId] [bigint] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](250) NOT NULL,
	[PreviousValue] [nvarchar](4000) NULL,
	[CurrentValue] [nvarchar](4000) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_AuditTracking] PRIMARY KEY CLUSTERED 
(
	[AuditTrackingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[LabOrganization]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[LabOrganization](
	[LabOrganizationId] [int] IDENTITY(1,1) NOT NULL,
	[LabOrganizationName] [nvarchar](250) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_LabOrganization] PRIMARY KEY CLUSTERED 
(
	[LabOrganizationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_LabOrganization_LabOrganizationName] UNIQUE NONCLUSTERED 
(
	[LabOrganizationName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementData]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementData](
	[DataFileId] [bigint] NOT NULL,
	[MeasurementDataId] [bigint] IDENTITY(1,1) NOT NULL,
	[MonitorId] [nvarchar](50) NULL,
	[SensorId] [nvarchar](50) NULL,
	[ParameterId] [int] NULL,
	[MethodDetectionLimit] [float] NULL,
	[DetectionRangeUnits] [nvarchar](50) NULL,
	[LabOrganization] [nvarchar](50) NULL,
	[Date] [int] NULL,
	[StartTime] [time](7) NULL,
	[MeasurementValue] [float] NULL,
	[MeasurementUnits] [int] NOT NULL,
	[AdjustedMeasurementValue] [float] NULL,
	[AdjustmentTechnique] [int] NULL,
	[Uncertainty] [nvarchar](50) NULL,
	[Quality] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
	[IsApproved] [nvarchar](3) NULL,
	[ApprovedBy] [int] NULL,
	[ChannelAMeasurementValue] [numeric](18, 0) NULL,
	[ChannelBMeasurementValue] [numeric](18, 0) NULL,
	[ChannelCMeasurementValue] [numeric](18, 0) NULL,
	[ChannelAAdjustedMeasurementValue] [numeric](18, 0) NULL,
	[ChannelDAdjustedMeasurementValue] [numeric](18, 0) NULL,
	[ChannelCAdjustedMeasurementValue] [numeric](18, 0) NULL,
 CONSTRAINT [PK_MeasurementData] PRIMARY KEY CLUSTERED 
(
	[DataFileId] ASC,
	[MeasurementDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementFile]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementFile](
	[MeasurementFileId] [int] IDENTITY(1,1) NOT NULL,
	[SubmittedFileName] [nvarchar](500) NOT NULL,
	[SubmittedFile] [varbinary](max) NOT NULL,
	[FileIsValid] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MeasurementFile] PRIMARY KEY CLUSTERED 
(
	[MeasurementFileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementFileArchive]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementFileArchive](
	[MeasurementFileId] [int] NOT NULL,
	[SubmittedFileName] [nvarchar](500) NOT NULL,
	[SubmittedFile] [varbinary](max) NOT NULL,
	[ArchivedDate] [datetime2](0) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MeasurementFileArchive] PRIMARY KEY CLUSTERED 
(
	[MeasurementFileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementHour]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementHour](
	[MeasurementHourId] [int] IDENTITY(1,1) NOT NULL,
	[StandardHour24] [nvarchar](10) NOT NULL,
	[HourOfDay24] [int] NOT NULL,
	[StandardHour12] [nvarchar](10) NOT NULL,
	[HourOfDay12] [int] NOT NULL,
 CONSTRAINT [PK_MeasurementHour] PRIMARY KEY CLUSTERED 
(
	[MeasurementHourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementStaging]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementStaging](
	[MeasurementFileId] [int] NOT NULL,
	[RecordId] [int] NOT NULL,
	[SiteID] [nvarchar](500) NULL,
	[MonitorID] [nvarchar](500) NULL,
	[Parameter] [nvarchar](500) NULL,
	[MethodDetectionLimit] [nvarchar](500) NULL,
	[DetectionRangeUnit] [nvarchar](500) NULL,
	[LabOrganization] [nvarchar](500) NULL,
	[MeasurementDate] [nvarchar](500) NULL,
	[MeasurementStartTime] [nvarchar](500) NULL,
	[ChannelAMeasurementValue] [nvarchar](500) NULL,
	[ChannelBMeasurementValue] [nvarchar](500) NULL,
	[ChannelCMeasurementValue] [nvarchar](500) NULL,
	[MeasurementUnit] [nvarchar](500) NULL,
	[ChannelAAdjustedMeasurementValue] [nvarchar](500) NULL,
	[ChannelBAdjustedMeasurementValue] [nvarchar](500) NULL,
	[ChannelCAdjustedMeasurementValue] [nvarchar](500) NULL,
	[AdjustmentTechnique] [nvarchar](500) NULL,
	[Uncertainty] [nvarchar](500) NULL,
	[Quality] [nvarchar](500) NULL,
	[RecordIsValid] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
	[IsApproved] [bit] NULL,
	[ApprovedBy] [int] NULL,
 CONSTRAINT [PK_MeasurementStaging] PRIMARY KEY CLUSTERED 
(
	[MeasurementFileId] ASC,
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementStagingArchive]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementStagingArchive](
	[MeasurementFileId] [int] NOT NULL,
	[RecordId] [int] NOT NULL,
	[SiteID] [nvarchar](500) NULL,
	[MonitorID] [nvarchar](500) NULL,
	[Parameter] [nvarchar](500) NULL,
	[MethodDetectionLimit] [nvarchar](500) NULL,
	[DetectionRangeUnit] [nvarchar](500) NULL,
	[LabOrganization] [nvarchar](500) NULL,
	[MeasurementDate] [nvarchar](500) NULL,
	[MeasurementStartTime] [nvarchar](500) NULL,
	[ChannelAMeasurementValue] [nvarchar](500) NULL,
	[ChannelBMeasurementValue] [nvarchar](500) NULL,
	[ChannelCMeasurementValue] [nvarchar](500) NULL,
	[MeasurementUnit] [nvarchar](500) NULL,
	[ChannelAAdjustedMeasurementValue] [nvarchar](500) NULL,
	[ChannelBAdjustedMeasurementValue] [nvarchar](500) NULL,
	[ChannelCAdjustedMeasurementValue] [nvarchar](500) NULL,
	[AdjustmentTechnique] [nvarchar](500) NULL,
	[Uncertainty] [nvarchar](500) NULL,
	[Quality] [nvarchar](500) NULL,
	[RecordIsValid] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
	[IsApproved] [bit] NULL,
	[ApprovedBy] [int] NULL,
 CONSTRAINT [PK_MeasurementStagingArchive] PRIMARY KEY CLUSTERED 
(
	[MeasurementFileId] ASC,
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementTechnique]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementTechnique](
	[MeasurementTechniqueId] [int] IDENTITY(1,1) NOT NULL,
	[ParameterId] [int] NOT NULL,
	[ParameterCode] [nvarchar](10) NOT NULL,
	[MeasurementTechniqueCode] [nvarchar](50) NOT NULL,
	[MeasurementTechniqueDescription] [nvarchar](200) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MeasurementTechnique] PRIMARY KEY CLUSTERED 
(
	[MeasurementTechniqueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_MeasurementTechnique] UNIQUE NONCLUSTERED 
(
	[ParameterCode] ASC,
	[MeasurementTechniqueCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MeasurementUnit]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MeasurementUnit](
	[MeasurementUnitId] [int] IDENTITY(1,1) NOT NULL,
	[MeasurementUnitCode] [nvarchar](25) NOT NULL,
	[MeasurementUnitAbbreviation] [nvarchar](50) NULL,
	[MeasurementUnitDescription] [nvarchar](150) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MeasurementUnit] PRIMARY KEY CLUSTERED 
(
	[MeasurementUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_MeasurementUnit_MeasurementUnitCode] UNIQUE NONCLUSTERED 
(
	[MeasurementUnitCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MetadataFile]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MetadataFile](
	[MetadataFileId] [int] IDENTITY(1,1) NOT NULL,
	[SubmittedFileName] [nvarchar](500) NOT NULL,
	[SubmittedFile] [varbinary](max) NOT NULL,
	[FileIsValid] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MetadataFile] PRIMARY KEY CLUSTERED 
(
	[MetadataFileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_MetadataFile_SubmittedFileName] UNIQUE NONCLUSTERED 
(
	[SubmittedFileName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [stream].[MetadataFileArchive]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MetadataFileArchive](
	[MetadataFileId] [int] NOT NULL,
	[SubmittedFileName] [nvarchar](500) NOT NULL,
	[SubmittedFile] [varbinary](max) NOT NULL,
	[ArchivedDate] [datetime2](0) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MetadataFileArchive] PRIMARY KEY CLUSTERED 
(
	[MetadataFileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [stream].[MetadataStaging]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MetadataStaging](
	[MetadataFileId] [int] NOT NULL,
	[RecordId] [int] NOT NULL,
	[TransactionType] [nvarchar](10) NOT NULL,
	[CommunityName] [nvarchar](500) NULL,
	[SiteName] [nvarchar](500) NULL,
	[SiteID] [nvarchar](500) NULL,
	[Latitude] [nvarchar](500) NULL,
	[Longitude] [nvarchar](500) NULL,
	[Elevation] [nvarchar](500) NULL,
	[CFRSiting] [nvarchar](500) NULL,
	[MonitorPurpose] [nvarchar](500) NULL,
	[MonitorID] [nvarchar](500) NULL,
	[MonitorManufacturer] [nvarchar](500) NULL,
	[MonitorModel] [nvarchar](500) NULL,
	[FirmwareVersion] [nvarchar](500) NULL,
	[Parameter] [nvarchar](500) NULL,
	[MeasurementTechnique] [nvarchar](500) NULL,
	[MeasurementUnit] [nvarchar](500) NULL,
	[SamplingFrequency] [nvarchar](500) NULL,
	[SamplingDuration] [nvarchar](500) NULL,
	[UpperDetectionLimit] [nvarchar](500) NULL,
	[LowerDetectionLimit] [nvarchar](500) NULL,
	[MethodDetectionLimit] [nvarchar](500) NULL,
	[DetectionRangeUnits] [nvarchar](500) NULL,
	[MonitorUncertainty] [nvarchar](500) NULL,
	[MeasurementPrecision] [nvarchar](500) NULL,
	[SystemDescription] [nvarchar](500) NULL,
	[MonitorPurchaseDate] [nvarchar](500) NULL,
	[LastCalibrationTimestamp] [nvarchar](500) NULL,
	[LastServiceDate] [nvarchar](500) NULL,
	[InletOrientation] [nvarchar](500) NULL,
	[InletHeight] [nvarchar](500) NULL,
	[InletDiameter] [nvarchar](500) NULL,
	[FlowRate] [nvarchar](500) NULL,
	[MeasurementResolution] [nvarchar](500) NULL,
	[Explanation] [nvarchar](500) NULL,
	[StartDate] [nvarchar](500) NULL,
	[EndDate] [nvarchar](500) NULL,
	[RecordIsValid] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
	[IsApproved] [bit] NULL,
	[ApprovedBy] [int] NULL,
 CONSTRAINT [PK_MetadataStaging] PRIMARY KEY CLUSTERED 
(
	[MetadataFileId] ASC,
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MetadataStagingArchive]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MetadataStagingArchive](
	[MetadataFileId] [int] NOT NULL,
	[RecordId] [int] NOT NULL,
	[TransactionType] [nvarchar](10) NOT NULL,
	[CommunityName] [nvarchar](500) NULL,
	[SiteName] [nvarchar](500) NULL,
	[SiteID] [nvarchar](500) NULL,
	[Latitude] [nvarchar](500) NULL,
	[Longitude] [nvarchar](500) NULL,
	[Elevation] [nvarchar](500) NULL,
	[CFRSiting] [nvarchar](500) NULL,
	[MonitorPurpose] [nvarchar](500) NULL,
	[MonitorID] [nvarchar](500) NULL,
	[MonitorManufacturer] [nvarchar](500) NULL,
	[MonitorModel] [nvarchar](500) NULL,
	[FirmwareVersion] [nvarchar](500) NULL,
	[Parameter] [nvarchar](500) NULL,
	[MeasurementTechnique] [nvarchar](500) NULL,
	[MeasurementUnit] [nvarchar](500) NULL,
	[SamplingFrequency] [nvarchar](500) NULL,
	[SamplingDuration] [nvarchar](500) NULL,
	[UpperDetectionLimit] [nvarchar](500) NULL,
	[LowerDetectionLimit] [nvarchar](500) NULL,
	[MethodDetectionLimit] [nvarchar](500) NULL,
	[DetectionRangeUnits] [nvarchar](500) NULL,
	[MonitorUncertainty] [nvarchar](500) NULL,
	[MeasurementPrecision] [nvarchar](500) NULL,
	[SystemDescription] [nvarchar](500) NULL,
	[MonitorPurchaseDate] [nvarchar](500) NULL,
	[LastCalibrationTimestamp] [nvarchar](500) NULL,
	[LastServiceDate] [nvarchar](500) NULL,
	[InletOrientation] [nvarchar](500) NULL,
	[InletHeight] [nvarchar](500) NULL,
	[InletDiameter] [nvarchar](500) NULL,
	[FlowRate] [nvarchar](500) NULL,
	[MeasurementResolution] [nvarchar](500) NULL,
	[Explanation] [nvarchar](500) NULL,
	[StartDate] [nvarchar](500) NULL,
	[EndDate] [nvarchar](500) NULL,
	[RecordIsValid] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
	[IsApproved] [bit] NULL,
	[ApprovedBy] [int] NULL,
 CONSTRAINT [PK_MetadataStagingArchive] PRIMARY KEY CLUSTERED 
(
	[MetadataFileId] ASC,
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[Monitor]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[Monitor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MonitorId] [varchar](max) NOT NULL,
	[SensorId] [varchar](max) NULL,
	[MonitorName] [varchar](max) NULL,
	[Latitude] [decimal](12, 9) NULL,
	[Longitude] [decimal](12, 9) NULL,
	[LastEntryId] [varchar](max) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[SiteId] [varchar](max) NULL,
	[Elevation] [varchar](max) NULL,
	[CFRString] [varchar](max) NULL,
	[MonitorPurpose] [varchar](max) NULL,
	[MonitorManufacturer] [varchar](max) NULL,
	[MonitorModel] [varchar](max) NULL,
	[FirmwareVersion] [varchar](max) NULL,
	[Parameter] [int] NULL,
	[MeasurementTechnique] [varchar](max) NULL,
	[SamplingFrequency] [varchar](max) NULL,
	[SamplingDuration] [varchar](max) NULL,
	[UpperDetectionLimit] [varchar](max) NULL,
	[LowerDetectionLimit] [varchar](max) NULL,
	[MethodDetectionLimit] [varchar](max) NULL,
	[DetectionRangeUnits] [varchar](max) NULL,
	[MonitorUncertainty] [varchar](max) NULL,
	[Precision] [varchar](max) NULL,
	[SystemDescription] [varchar](max) NULL,
	[MonitorPurchaseDate] [varchar](max) NULL,
	[LastCalibrationTimestamp] [varchar](max) NULL,
	[LastServiceDate] [varchar](max) NULL,
	[InletOrientation] [varchar](max) NULL,
	[InletHeight] [varchar](max) NULL,
	[InletDiameter] [varchar](max) NULL,
	[FlowRate] [varchar](max) NULL,
	[MeasurementResolution] [varchar](max) NULL,
	[Explanation] [varchar](max) NULL,
	[Effective Date] [datetime2](7) NULL,
	[SystemDescripion] [varchar](max) NULL,
	[Active] [bit] NULL,
	[RelocateStartDate] [datetime2](7) NULL,
	[RelocateEndDate] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [stream].[MonitorMfrModelParameter]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MonitorMfrModelParameter](
	[MonitorMfrModelParameterId] [int] IDENTITY(1,1) NOT NULL,
	[MonitorMfrModelId] [int] NOT NULL,
	[ParameterId] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MonitorMfrModelParameter] PRIMARY KEY CLUSTERED 
(
	[MonitorMfrModelParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_MonitorMfrModelParameter] UNIQUE NONCLUSTERED 
(
	[MonitorMfrModelId] ASC,
	[ParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[MonitorMfrModelParameterDetails]    Script Date: 3/6/2019 5:03:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[MonitorMfrModelParameterDetails](
	[MonitorMfrModelParameterDetailsId] [int] IDENTITY(1,1) NOT NULL,
	[MonitorMfrModelParameterId] [int] NOT NULL,
	[MeasurementTechniqueId] [int] NULL,
	[MeasurementUnitId] [int] NOT NULL,
	[SampleDurationId] [int] NULL,
	[SampleFrequencyId] [int] NULL,
	[DetectionRangeUnitId] [int] NULL,
	[UpperDetectionLimit] [float] NULL,
	[LowerDetectionLimit] [float] NULL,
	[MethodDetectionLimit] [float] NULL,
	[Uncertainty] [nvarchar](250) NULL,
	[MonitorPrecision] [nvarchar](250) NULL,
	[MeasurementResolution] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MonitorMfrModelParameterDetails] PRIMARY KEY CLUSTERED 
(
	[MonitorMfrModelParameterDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[QualityFlag]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[QualityFlag](
	[QualityFlagId] [int] IDENTITY(1,1) NOT NULL,
	[DataProviderId] [int] NOT NULL,
	[DataProviderFlag] [nvarchar](25) NULL,
	[FlagDescription] [nvarchar](100) NULL,
	[InternalFlag] [int] NULL,
	[InternalFlagDescription] [nvarchar](100) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_QualityFlag] PRIMARY KEY CLUSTERED 
(
	[QualityFlagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_QualityFlag_DataProviderFlag] UNIQUE NONCLUSTERED 
(
	[DataProviderFlag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[SampleDuration]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SampleDuration](
	[SampleDurationId] [int] IDENTITY(1,1) NOT NULL,
	[SampleDurationCode] [nvarchar](10) NOT NULL,
	[SampleDurationDescription] [nvarchar](50) NOT NULL,
	[ObservedOrCalculated] [nvarchar](25) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SampleDuration] PRIMARY KEY CLUSTERED 
(
	[SampleDurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_SampleDuration_SampleDurationCode] UNIQUE NONCLUSTERED 
(
	[SampleDurationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[SampleFrequency]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SampleFrequency](
	[SampleFrequencyId] [int] IDENTITY(1,1) NOT NULL,
	[SampleFrequencyCode] [nvarchar](10) NOT NULL,
	[SampleFrequencyDescription] [nvarchar](50) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SampleFrequency] PRIMARY KEY CLUSTERED 
(
	[SampleFrequencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_SampleFrequency_SampleFrequencyCode] UNIQUE NONCLUSTERED 
(
	[SampleFrequencyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[SiteData]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SiteData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [varchar](50) NULL,
	[Elevation] [varchar](50) NULL,
	[SiteName] [varchar](50) NULL,
	[CommunityProjectName] [nvarchar](100) NULL,
	[Latitude] [decimal](12, 9) NULL,
	[Longitude] [decimal](12, 9) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
	[Active] [bit] NULL,
	[RelocationStartDate] [datetime2](7) NULL,
	[RelocationEndDate] [datetime2](7) NULL,
	[Explanation] [nvarchar](50) NULL,
	[userId] [int] NOT NULL,
	[DeactivationEndDate] [datetime2](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[SiteLocationHistory]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SiteLocationHistory](
	[SiteLocationHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[SiteLocationId] [int] NOT NULL,
	[OriginalUserSiteCode] [nvarchar](250) NOT NULL,
	[OriginalSiteName] [nvarchar](250) NULL,
	[OriginalLatitude] [decimal](12, 9) NOT NULL,
	[OriginalLongitude] [decimal](12, 9) NOT NULL,
	[OriginalElevation] [decimal](9, 4) NOT NULL,
	[NewUserSiteCode] [nvarchar](250) NOT NULL,
	[NewSiteName] [nvarchar](250) NULL,
	[NewLatitude] [decimal](12, 9) NOT NULL,
	[NewLongitude] [decimal](12, 9) NOT NULL,
	[NewElevation] [decimal](9, 4) NOT NULL,
	[Explanation] [nvarchar](4000) NULL,
	[IsApproved] [bit] NULL,
	[ApprovedBy] [int] NOT NULL,
	[ApprovedDate] [datetime2](0) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SiteLocationHistory] PRIMARY KEY CLUSTERED 
(
	[SiteLocationHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[SiteMonitorHistory]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SiteMonitorHistory](
	[SiteMonitorHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[SiteMonitorId] [int] NOT NULL,
	[OriginalSiteLocationId] [int] NOT NULL,
	[OriginalMonitorMfrModelId] [int] NOT NULL,
	[OriginalMonitorCode] [nvarchar](250) NULL,
	[OriginalMonitorPurposeId] [int] NULL,
	[OriginalFirmwareVersion] [nvarchar](50) NULL,
	[OriginalMonitorPurchaseDate] [date] NULL,
	[OriginalLastServiceDate] [date] NULL,
	[OriginalCFRSiting] [bit] NULL,
	[OriginalFlowRate] [nvarchar](50) NULL,
	[OriginalInletHeight] [float] NULL,
	[OriginalInletOrientation] [int] NULL,
	[OriginalInletDiameter] [float] NULL,
	[OriginalSystemDescription] [nvarchar](500) NULL,
	[OriginalIsActive] [bit] NULL,
	[NewSiteLocationId] [int] NOT NULL,
	[NewMonitorMfrModelId] [int] NOT NULL,
	[NewMonitorCode] [nvarchar](250) NULL,
	[NewMonitorPurposeId] [int] NULL,
	[NewFirmwareVersion] [nvarchar](50) NULL,
	[NewMonitorPurchaseDate] [date] NULL,
	[NewLastServiceDate] [date] NULL,
	[NewCFRSiting] [bit] NULL,
	[NewFlowRate] [nvarchar](50) NULL,
	[NewInletHeight] [float] NULL,
	[NewInletOrientation] [int] NULL,
	[NewInletDiameter] [float] NULL,
	[NewSystemDescription] [nvarchar](500) NULL,
	[NewIsActive] [bit] NULL,
	[Explanation] [nvarchar](4000) NULL,
	[IsApproved] [bit] NULL,
	[ApprovedBy] [int] NOT NULL,
	[ApprovedDate] [datetime2](0) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SiteMonitorHistory] PRIMARY KEY CLUSTERED 
(
	[SiteMonitorHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stream].[SiteMonitorParameter]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SiteMonitorParameter](
	[SiteMonitorParameterId] [int] IDENTITY(1,1) NOT NULL,
	[SiteMonitorId] [nvarchar](max) NOT NULL,
	[ParameterId] [int] NOT NULL,
	[MeasurementTechniqueId] [int] NULL,
	[MeasurementUnitId] [int] NULL,
	[SampleFrequencyId] [nvarchar](50) NULL,
	[SampleDurationId] [int] NULL,
	[UpperDetectionLimit] [float] NULL,
	[LowerDetectionLimit] [float] NULL,
	[MethodDetectionLimit] [float] NULL,
	[DetectionRangeUnitId] [int] NULL,
	[Uncertainty] [nvarchar](max) NULL,
	[LastCalibrationTimestamp] [datetime2](7) NULL,
	[IsActive] [bit] NULL,
	[AllowStream] [bit] NULL,
	[DisplayStream] [bit] NULL,
	[ActionTaken] [nvarchar](max) NULL,
	[StartDate] [datetime2](7) NULL,
	[EndDate] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_SiteMonitorParameter] PRIMARY KEY CLUSTERED 
(
	[SiteMonitorParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [stream].[SystemEventLog]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stream].[SystemEventLog](
	[SystemEventLogId] [bigint] IDENTITY(1,1) NOT NULL,
	[EventDateTime] [datetime2](7) NOT NULL,
	[EventNumber] [int] NOT NULL,
	[EventType] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[ServerName] [nvarchar](50) NOT NULL,
	[EventMessage] [nvarchar](4000) NOT NULL,
 CONSTRAINT [PK_SystemEventLogId] PRIMARY KEY CLUSTERED 
(
	[SystemEventLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[AuditTracking]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[AuditTracking](
	[AuditTrackingId] [bigint] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](250) NOT NULL,
	[PreviousValue] [nvarchar](4000) NULL,
	[CurrentValue] [nvarchar](4000) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_AuditTracking] PRIMARY KEY CLUSTERED 
(
	[AuditTrackingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[Community]    Script Date: 3/6/2019 5:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[Community](
	[CommunityId] [int] IDENTITY(1,1) NOT NULL,
	[CommunityName] [nvarchar](255) NULL,
	[ProjectName] [nvarchar](255) NULL,
	[StateName] [nvarchar](50) NULL,
	[AirBasin] [nvarchar](50) NULL,
	[AirDistrict] [nvarchar](50) NULL,
	[County] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Community_temp_stream] PRIMARY KEY CLUSTERED 
(
	[CommunityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_Community_CommunityName] UNIQUE NONCLUSTERED 
(
	[CommunityName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[DataFile]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[DataFile](
	[DataFileId] [int] IDENTITY(1,1) NOT NULL,
	[SubmittedFileName] [nvarchar](500) NOT NULL,
	[SubmittedFile] [varbinary](max) NOT NULL,
	[FileIsLoaded] [bit] NOT NULL,
	[LoadingErrors] [nvarchar](4000) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime2](0) NULL,
 CONSTRAINT [PK_DataFile] PRIMARY KEY CLUSTERED 
(
	[DataFileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[DataFileArchive]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[DataFileArchive](
	[DataFileId] [bigint] NOT NULL,
	[SubmittedFileName] [nvarchar](500) NOT NULL,
	[SubmittedFile] [varbinary](max) NOT NULL,
	[ArchivedDate] [datetime2](0) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_DataFileArchive] PRIMARY KEY CLUSTERED 
(
	[DataFileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[DataProvider]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[DataProvider](
	[DataProviderId] [int] IDENTITY(1,1) NOT NULL,
	[DataProviderCode] [int] NOT NULL,
	[DataProviderLongName] [nvarchar](200) NULL,
	[DataProviderShortName] [nvarchar](50) NULL,
	[DataProviderType] [nvarchar](25) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_DataProvider_temp_stream] PRIMARY KEY CLUSTERED 
(
	[DataProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_DataProvider_DataProviderCode] UNIQUE NONCLUSTERED 
(
	[DataProviderCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[DataProviderType]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[DataProviderType](
	[DataProviderTypeId] [int] NOT NULL,
	[DataProviderTypeCode] [nvarchar](25) NOT NULL,
	[DataProviderTypeDescription] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[FileLoadingError]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[FileLoadingError](
	[FileLoadingErrorId] [int] NOT NULL,
	[ErrorDescription] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[Instrument]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[Instrument](
	[InstrumentId] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nvarchar](150) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[MeasurementTechniqueCode] [int] NULL,
	[ParameterCode] [nvarchar](10) NOT NULL,
	[StandardUnitsCode] [nvarchar](50) NULL,
	[MonitorResolution] [nvarchar](50) NULL,
	[UpperDetectionLimit] [nvarchar](50) NULL,
	[LowerDetectionLimit] [nvarchar](50) NULL,
	[MethodDetectionLimit] [nvarchar](50) NULL,
	[DetectionRangeUnits] [nvarchar](50) NULL,
	[Uncertainty] [nvarchar](200) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Instrument] PRIMARY KEY CLUSTERED 
(
	[InstrumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_Monitor] UNIQUE NONCLUSTERED 
(
	[Manufacturer] ASC,
	[Model] ASC,
	[ParameterCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[MeasurementTechnique]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[MeasurementTechnique](
	[MeasurementTechniqueId] [int] NOT NULL,
	[MeasurementTechniqueCode] [nvarchar](50) NOT NULL,
	[MeasurementTechniqueDescription] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[MeasurementUnit]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[MeasurementUnit](
	[MeasurementUnitId] [int] NOT NULL,
	[MeasurementUnitCode] [nvarchar](25) NOT NULL,
	[MeasurementUnitAbbreviation] [nvarchar](50) NULL,
	[MeasurementUnitDescription] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[MonitorPurpose]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[MonitorPurpose](
	[MonitorPurposeId] [int] IDENTITY(1,1) NOT NULL,
	[MonitorPurposeCode] [int] NOT NULL,
	[MonitorPurpose] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MonitorPurpose_temp_stream] PRIMARY KEY CLUSTERED 
(
	[MonitorPurposeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_MonitorPurpose_MonitorPurposeCode] UNIQUE NONCLUSTERED 
(
	[MonitorPurposeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[MonitorStaging]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[MonitorStaging](
	[MonitorStagingId] [int] IDENTITY(1,1) NOT NULL,
	[MonitorName] [nvarchar](100) NOT NULL,
	[Latitude] [decimal](12, 9) NULL,
	[Longitude] [decimal](12, 9) NULL,
	[Field1] [nvarchar](50) NULL,
	[Field2] [nvarchar](50) NULL,
	[Field3] [nvarchar](50) NULL,
	[Field4] [nvarchar](50) NULL,
	[Field5] [nvarchar](50) NULL,
	[Field6] [nvarchar](50) NULL,
	[Field7] [nvarchar](50) NULL,
	[Field8] [nvarchar](50) NULL,
	[LastEntryId] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_MonitorStaging] PRIMARY KEY CLUSTERED 
(
	[MonitorStagingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IUX_MonitorStaging_MonitorName_Latitude_Longitude] UNIQUE NONCLUSTERED 
(
	[MonitorName] ASC,
	[Latitude] ASC,
	[Longitude] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[Parameter]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[Parameter](
	[ParameterId] [int] IDENTITY(1,1) NOT NULL,
	[ParameterCode] [int] NOT NULL,
	[Parameter] [nvarchar](100) NOT NULL,
	[StandardUnits] [nvarchar](100) NULL,
	[RoundOrTruncate] [nchar](1) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Parameter_temp_stream] PRIMARY KEY CLUSTERED 
(
	[ParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_Parameter_ParameterCode] UNIQUE NONCLUSTERED 
(
	[ParameterCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[SampleDuration]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[SampleDuration](
	[SampleDurationId] [int] IDENTITY(1,1) NOT NULL,
	[SampleDurationCode] [nvarchar](10) NOT NULL,
	[SampleDurationDescription] [nvarchar](50) NOT NULL,
	[ObservedOrCalculated] [nvarchar](10) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SampleDuration_temp_stream] PRIMARY KEY CLUSTERED 
(
	[SampleDurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_SampleDuration_SampleDurationCode] UNIQUE NONCLUSTERED 
(
	[SampleDurationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[SampleQualityCode]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[SampleQualityCode](
	[SampleQualityCodeId] [int] IDENTITY(1,1) NOT NULL,
	[SampleQualityCode] [int] NOT NULL,
	[SampleQualityDescription] [nvarchar](250) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SampleQualityCode] PRIMARY KEY CLUSTERED 
(
	[SampleQualityCodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_SampleQualityCode_SampleQualityCode] UNIQUE NONCLUSTERED 
(
	[SampleQualityCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[SampleUnit]    Script Date: 3/6/2019 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[SampleUnit](
	[SampleUnitId] [int] IDENTITY(1,1) NOT NULL,
	[SampleUnitCode] [nvarchar](25) NOT NULL,
	[SampleUnitDescription] [nvarchar](150) NULL,
	[SampleUnitAbbreviation] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[SampleUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_Unit_UnitCode] UNIQUE NONCLUSTERED 
(
	[SampleUnitCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[SensorStreamData]    Script Date: 3/6/2019 5:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[SensorStreamData](
	[SensorStreamData] [bigint] IDENTITY(1,1) NOT NULL,
	[SensorVendorId] [int] NOT NULL,
	[SensorId] [int] NOT NULL,
	[SensorName] [nvarchar](150) NULL,
	[Latitude] [decimal](12, 9) NOT NULL,
	[Longitude] [decimal](12, 9) NOT NULL,
	[ParameterId] [int] NOT NULL,
	[MeasurementValue] [float] NULL,
	[UpTime] [int] NULL,
	[TemperatureInFahrenheit] [float] NULL,
	[HumidityPercent] [float] NULL,
	[LastEntryId] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_SensorVendorStreamData] PRIMARY KEY CLUSTERED 
(
	[SensorStreamData] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_SensorVendorStreamData_SensorVendor] UNIQUE NONCLUSTERED 
(
	[SensorVendorId] ASC,
	[SensorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[SetupMetadata]    Script Date: 3/6/2019 5:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[SetupMetadata](
	[DataFileId] [int] NOT NULL,
	[SetupMetadataId] [bigint] IDENTITY(1,1) NOT NULL,
	[TransactionTypeId] [int] NULL,
	[CommunityId] [int] NULL,
	[SiteName] [nvarchar](250) NULL,
	[SiteId] [nvarchar](50) NULL,
	[Latitude] [decimal](12, 9) NULL,
	[Longitude] [decimal](12, 9) NULL,
	[Elevation] [float] NULL,
	[CFRSiting] [int] NULL,
	[MonitorPurposeId] [int] NULL,
	[DataProviderId] [int] NOT NULL,
	[SensorId] [nvarchar](50) NULL,
	[InstrumentId] [int] NULL,
	[MonitorModel] [nvarchar](250) NULL,
	[FirmwareVersion] [nvarchar](50) NULL,
	[ParameterId] [int] NULL,
	[MeasurementTechnique] [nvarchar](50) NULL,
	[SamplingFrequency] [nvarchar](50) NULL,
	[SampleDurationId] [int] NULL,
	[UpperDetectionLimit] [float] NULL,
	[LowerDetectionLimit] [float] NULL,
	[MethodDetectionLimit] [float] NULL,
	[DetectionRangeUnits] [nvarchar](50) NULL,
	[MonitorUncertainty] [nvarchar](50) NULL,
	[MonitorPrecision] [nvarchar](50) NULL,
	[SystemDescription] [nvarchar](250) NULL,
	[MonitorPurchaseDate] [int] NULL,
	[LastCalibrationTimestamp] [datetime2](0) NULL,
	[LastServiceDate] [int] NULL,
	[InletOrientation] [int] NULL,
	[InletHeight] [float] NULL,
	[InletDiameter] [float] NULL,
	[FlowRate] [nvarchar](50) NULL,
	[MeasurementResolution] [int] NULL,
	[Explanation] [nvarchar](4000) NULL,
	[EffectiveDate] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
	[IsApproved] [nvarchar](3) NULL,
	[ApprovedBy] [int] NULL,
 CONSTRAINT [PK_SetupAndMetadata] PRIMARY KEY CLUSTERED 
(
	[DataFileId] ASC,
	[SetupMetadataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[TimeSeriesStaging]    Script Date: 3/6/2019 5:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[TimeSeriesStaging](
	[TimeSeriesStagingId] [bigint] IDENTITY(1,1) NOT NULL,
	[MonitorStagingId] [int] NOT NULL,
	[Field1] [decimal](12, 9) NULL,
	[Field2] [decimal](12, 9) NULL,
	[Field3] [decimal](12, 9) NULL,
	[Field4] [decimal](12, 9) NULL,
	[Field5] [decimal](12, 9) NULL,
	[Field6] [decimal](12, 9) NULL,
	[Field7] [decimal](12, 9) NULL,
	[Field8] [decimal](12, 9) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_TimeSeriesStaging] PRIMARY KEY CLUSTERED 
(
	[TimeSeriesStagingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_TimeSeriesStaging_TimeSeriesStagingId_MonitorId] UNIQUE NONCLUSTERED 
(
	[TimeSeriesStagingId] ASC,
	[MonitorStagingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [temp_stream].[TransactionType]    Script Date: 3/6/2019 5:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [temp_stream].[TransactionType](
	[TransactionTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TransactionTypeCode] [nvarchar](25) NOT NULL,
	[TransactionTypeDefinition] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](500) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_TransactionType] PRIMARY KEY CLUSTERED 
(
	[TransactionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IXU_TransactionType_TransactionType] UNIQUE NONCLUSTERED 
(
	[TransactionTypeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ReportFile_ReportFileTypeId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_ReportFile_ReportFileTypeId] ON [report].[ReportFile]
(
	[ReportFileTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdjustmentTechnique_DataProviderId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AdjustmentTechnique_DataProviderId] ON [stream].[AdjustmentTechnique]
(
	[DataProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSite_DetectionRangeUnitId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSite_DetectionRangeUnitId] ON [stream].[AirMonitoringStreamSite]
(
	[DetectionRangeUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSite_MeasurementTechniqueId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSite_MeasurementTechniqueId] ON [stream].[AirMonitoringStreamSite]
(
	[MeasurementTechniqueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSite_MeasurementUnitId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSite_MeasurementUnitId] ON [stream].[AirMonitoringStreamSite]
(
	[MeasurementUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSite_ParameterId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSite_ParameterId] ON [stream].[AirMonitoringStreamSite]
(
	[ParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSite_SampleDurationId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSite_SampleDurationId] ON [stream].[AirMonitoringStreamSite]
(
	[SampleDurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSite_SampleFrequencyId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSite_SampleFrequencyId] ON [stream].[AirMonitoringStreamSite]
(
	[SampleFrequencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSite_SiteMonitorId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSite_SiteMonitorId] ON [stream].[AirMonitoringStreamSite]
(
	[SiteMonitorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AirMonitoringStreamSiteHistory_AirMonitoringStreamSiteId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_AirMonitoringStreamSiteHistory_AirMonitoringStreamSiteId] ON [stream].[AirMonitoringStreamSiteHistory]
(
	[AirMonitoringStreamSiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Community_DataProviderId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_Community_DataProviderId] ON [stream].[Community]
(
	[DataProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameter_MonitorMfrModelId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameter_MonitorMfrModelId] ON [stream].[MonitorMfrModelParameter]
(
	[MonitorMfrModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameter_ParameterId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameter_ParameterId] ON [stream].[MonitorMfrModelParameter]
(
	[ParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameterDetails_DetectionRangeUnitId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameterDetails_DetectionRangeUnitId] ON [stream].[MonitorMfrModelParameterDetails]
(
	[DetectionRangeUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameterDetails_MeasurementTechniqueId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameterDetails_MeasurementTechniqueId] ON [stream].[MonitorMfrModelParameterDetails]
(
	[MeasurementTechniqueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameterDetails_MeasurementUnitId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameterDetails_MeasurementUnitId] ON [stream].[MonitorMfrModelParameterDetails]
(
	[MeasurementUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameterDetails_MonitorMfrModelParameterId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameterDetails_MonitorMfrModelParameterId] ON [stream].[MonitorMfrModelParameterDetails]
(
	[MonitorMfrModelParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameterDetails_SampleDurationId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameterDetails_SampleDurationId] ON [stream].[MonitorMfrModelParameterDetails]
(
	[SampleDurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MonitorMfrModelParameterDetails_SampleFrequencyId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_MonitorMfrModelParameterDetails_SampleFrequencyId] ON [stream].[MonitorMfrModelParameterDetails]
(
	[SampleFrequencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_QualityFlag_DataProviderId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_QualityFlag_DataProviderId] ON [stream].[QualityFlag]
(
	[DataProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteLocation_CommunityId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_SiteLocation_CommunityId] ON [stream].[SiteLocation]
(
	[CommunityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteLocationHistory_SiteLocationId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_SiteLocationHistory_SiteLocationId] ON [stream].[SiteLocationHistory]
(
	[SiteLocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteMonitor_MonitorMfrModelId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_SiteMonitor_MonitorMfrModelId] ON [stream].[SiteMonitor]
(
	[MonitorMfrModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteMonitor_MonitorPurposeId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_SiteMonitor_MonitorPurposeId] ON [stream].[SiteMonitor]
(
	[MonitorPurposeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteMonitor_SiteLocationId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_SiteMonitor_SiteLocationId] ON [stream].[SiteMonitor]
(
	[SiteLocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteMonitorHistory_SiteMonitorId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_SiteMonitorHistory_SiteMonitorId] ON [stream].[SiteMonitorHistory]
(
	[SiteMonitorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TimeSeriesStaging_MonitorStagingId]    Script Date: 3/6/2019 5:03:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_TimeSeriesStaging_MonitorStagingId] ON [temp_stream].[TimeSeriesStaging]
(
	[MonitorStagingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [account].[AccessLevel] ADD  CONSTRAINT [DF_AccessLevel_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[AccessLevel] ADD  CONSTRAINT [DF_AccessLevel_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[AccessLevel] ADD  CONSTRAINT [DF_AccessLevel_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[AccessLevel] ADD  CONSTRAINT [DF_AccessLevel_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[ActivityLog] ADD  CONSTRAINT [DF_ActivityLog_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[ActivityLog] ADD  CONSTRAINT [DF_ActivityLog_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[ActivityLog] ADD  CONSTRAINT [DF_ActivityLog_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[ActivityLog] ADD  CONSTRAINT [DF_ActivityLog_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[AirDistrict] ADD  CONSTRAINT [DF_AirDistrict_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[AirDistrict] ADD  CONSTRAINT [DF_AirDistrict_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[AirDistrict] ADD  CONSTRAINT [DF_AirDistrict_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[AirDistrict] ADD  CONSTRAINT [DF_AirDistrict_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[CarbDivision] ADD  CONSTRAINT [DF_CarbDivision_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[CarbDivision] ADD  CONSTRAINT [DF_CarbDivision_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[CarbDivision] ADD  CONSTRAINT [DF_CarbDivision_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[CarbDivision] ADD  CONSTRAINT [DF_CarbDivision_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[Notification] ADD  CONSTRAINT [DF_Notification_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[Notification] ADD  CONSTRAINT [DF_Notification_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[Notification] ADD  CONSTRAINT [DF_Notification_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[Notification] ADD  CONSTRAINT [DF_Notification_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[PhoneType] ADD  CONSTRAINT [DF_PhoneType_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[PhoneType] ADD  CONSTRAINT [DF_PhoneType_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[PhoneType] ADD  CONSTRAINT [DF_PhoneType_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[PhoneType] ADD  CONSTRAINT [DF_PhoneType_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[Privilege] ADD  CONSTRAINT [DF_Privilege_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[Privilege] ADD  CONSTRAINT [DF_Privilege_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[Privilege] ADD  CONSTRAINT [DF_Privilege_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[Privilege] ADD  CONSTRAINT [DF_Privilege_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[Role] ADD  CONSTRAINT [DF_Role_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[Role] ADD  CONSTRAINT [DF_Role_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[Role] ADD  CONSTRAINT [DF_Role_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[Role] ADD  CONSTRAINT [DF_Role_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[User] ADD  CONSTRAINT [DF_User_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[User] ADD  CONSTRAINT [DF_User_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[User] ADD  CONSTRAINT [DF_User_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[User] ADD  CONSTRAINT [DF_User_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[UserDocument] ADD  CONSTRAINT [DF_UserDocument_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[UserDocument] ADD  CONSTRAINT [DF_UserDocument_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[UserDocument] ADD  CONSTRAINT [DF_UserDocument_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[UserDocument] ADD  CONSTRAINT [DF_UserDocument_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[UserType] ADD  CONSTRAINT [DF_UserType_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [account].[UserType] ADD  CONSTRAINT [DF_UserType_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [account].[UserType] ADD  CONSTRAINT [DF_UserType_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [account].[UserType] ADD  CONSTRAINT [DF_UserType_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [report].[ReportFile] ADD  CONSTRAINT [DF_ReportFile_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [report].[ReportFile] ADD  CONSTRAINT [DF_ReportFile_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [report].[ReportFile] ADD  CONSTRAINT [DF_ReportFile_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [report].[ReportFile] ADD  CONSTRAINT [DF_ReportFile_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [report].[ReportFileType] ADD  CONSTRAINT [DF_ReportFileType_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [report].[ReportFileType] ADD  CONSTRAINT [DF_ReportFileType_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [report].[ReportFileType] ADD  CONSTRAINT [DF_ReportFileType_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [report].[ReportFileType] ADD  CONSTRAINT [DF_ReportFileType_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[AdjustmentTechnique] ADD  CONSTRAINT [DF_AdjustmentTechnique_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[AdjustmentTechnique] ADD  CONSTRAINT [DF_AdjustmentTechnique_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[AdjustmentTechnique] ADD  CONSTRAINT [DF_AdjustmentTechnique_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[AdjustmentTechnique] ADD  CONSTRAINT [DF_AdjustmentTechnique_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] ADD  CONSTRAINT [DF_AirMonitoringStreamSite_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] ADD  CONSTRAINT [DFAirMonitoringStreamSite_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] ADD  CONSTRAINT [DF_AirMonitoringStreamSite_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] ADD  CONSTRAINT [DF_AirMonitoringStreamSite_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory] ADD  CONSTRAINT [DF_AirMonitoringStreamSiteHistory_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory] ADD  CONSTRAINT [DF_AirMonitoringStreamSiteHistory_ApprovedDate]  DEFAULT (getdate()) FOR [ApprovedDate]
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory] ADD  CONSTRAINT [DF_AirMonitoringStreamSiteHistory_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory] ADD  CONSTRAINT [DFAirMonitoringStreamSiteHistory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory] ADD  CONSTRAINT [DF_AirMonitoringStreamSiteHistory_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory] ADD  CONSTRAINT [DF_AirMonitoringStreamSiteHistory_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[Community] ADD  CONSTRAINT [DF_Community_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[Community] ADD  CONSTRAINT [DF_Community_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[Community] ADD  CONSTRAINT [DF_Community_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[Community] ADD  CONSTRAINT [DF_Community_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[LabOrganization] ADD  CONSTRAINT [DF_LabOrganization_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[LabOrganization] ADD  CONSTRAINT [DF_LabOrganization_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[LabOrganization] ADD  CONSTRAINT [DF_LabOrganization_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[LabOrganization] ADD  CONSTRAINT [DF_LabOrganization_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MeasurementData] ADD  CONSTRAINT [DF_MeasurementData_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MeasurementData] ADD  CONSTRAINT [DF_MeasurementData_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MeasurementData] ADD  CONSTRAINT [DF_MeasurementData_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MeasurementData] ADD  CONSTRAINT [DF_MeasurementData_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MeasurementFile] ADD  CONSTRAINT [DF_MeasurementFile_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MeasurementFile] ADD  CONSTRAINT [DF_MeasurementFile_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MeasurementFile] ADD  CONSTRAINT [DF_MeasurementFile_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MeasurementFile] ADD  CONSTRAINT [DF_MeasurementFile_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MeasurementFileArchive] ADD  CONSTRAINT [DF_MeasurementFileArchive_ArchivedDate]  DEFAULT (getdate()) FOR [ArchivedDate]
GO
ALTER TABLE [stream].[MeasurementStaging] ADD  CONSTRAINT [DF_MeasurementStaging_RecordIsValid]  DEFAULT ((1)) FOR [RecordIsValid]
GO
ALTER TABLE [stream].[MeasurementStaging] ADD  CONSTRAINT [DF_MeasurementStaging_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MeasurementStaging] ADD  CONSTRAINT [DF_MeasurementStaging_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MeasurementStaging] ADD  CONSTRAINT [DF_MeasurementStaging_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MeasurementStaging] ADD  CONSTRAINT [DF_MeasurementStaging_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MeasurementStaging] ADD  CONSTRAINT [DF_MeasurementStaging_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
ALTER TABLE [stream].[MeasurementStreamData] ADD  CONSTRAINT [DF_MeasurementStreamData_MeasurementStreamDataId]  DEFAULT (newid()) FOR [MeasurementStreamDataId]
GO
ALTER TABLE [stream].[MeasurementTechnique] ADD  CONSTRAINT [DF_MeasurementTechnique_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MeasurementTechnique] ADD  CONSTRAINT [DF_MeasurementTechnique_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MeasurementTechnique] ADD  CONSTRAINT [DF_MeasurementTechnique_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MeasurementTechnique] ADD  CONSTRAINT [DF_MeasurementTechnique_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MeasurementUnit] ADD  CONSTRAINT [DF_MeasurementUnit_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MeasurementUnit] ADD  CONSTRAINT [DF_MeasurementUnit_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MeasurementUnit] ADD  CONSTRAINT [DF_MeasurementUnit_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MeasurementUnit] ADD  CONSTRAINT [DF_MeasurementUnit_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MetadataFile] ADD  CONSTRAINT [DF_MetadataFile_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MetadataFile] ADD  CONSTRAINT [DF_MetadataFile_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MetadataFile] ADD  CONSTRAINT [DF_MetadataFile_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MetadataFile] ADD  CONSTRAINT [DF_MetadataFile_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MetadataFileArchive] ADD  CONSTRAINT [DF_MetadataFileArchive_ArchivedDate]  DEFAULT (getdate()) FOR [ArchivedDate]
GO
ALTER TABLE [stream].[MetadataStaging] ADD  CONSTRAINT [DF_MetadataStaging_RecordIsValid]  DEFAULT ((1)) FOR [RecordIsValid]
GO
ALTER TABLE [stream].[MetadataStaging] ADD  CONSTRAINT [DF_MetadataStaging_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MetadataStaging] ADD  CONSTRAINT [DF_MetadataStaging_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MetadataStaging] ADD  CONSTRAINT [DF_MetadataStaging_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MetadataStaging] ADD  CONSTRAINT [DF_MetadataStaging_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MetadataStaging] ADD  CONSTRAINT [DF_MetadataStaging_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
ALTER TABLE [stream].[Monitor] ADD  CONSTRAINT [DF_Monitor_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[Monitor] ADD  CONSTRAINT [DF_Monitor_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[Monitor] ADD  CONSTRAINT [DF_Monitor_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[Monitor] ADD  CONSTRAINT [DF_Monitor_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[Monitor] ADD  CONSTRAINT [DF_Monitor_Active]  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [stream].[MonitorMfrModel] ADD  CONSTRAINT [DF_MonitorMfrModel_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MonitorMfrModel] ADD  CONSTRAINT [DF_MonitorMfrModel_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MonitorMfrModel] ADD  CONSTRAINT [DF_MonitorMfrModel_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MonitorMfrModel] ADD  CONSTRAINT [DF_MonitorMfrModel_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MonitorMfrModelParameter] ADD  CONSTRAINT [DF_MonitorMfrModelParameter_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MonitorMfrModelParameter] ADD  CONSTRAINT [DF_MonitorMfrModelParameter_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MonitorMfrModelParameter] ADD  CONSTRAINT [DF_MonitorMfrModelParameter_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MonitorMfrModelParameter] ADD  CONSTRAINT [DF_MonitorMfrModelParameter_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] ADD  CONSTRAINT [DF_MonitorMfrModelParameterDetails_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] ADD  CONSTRAINT [DF_MonitorMfrModelParameterDetails_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] ADD  CONSTRAINT [DF_MonitorMfrModelParameterDetails_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] ADD  CONSTRAINT [DF_MonitorMfrModelParameterDetails_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[Parameter] ADD  CONSTRAINT [DF_Parameter_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[Parameter] ADD  CONSTRAINT [DF_Parameter_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[Parameter] ADD  CONSTRAINT [DF_Parameter_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[Parameter] ADD  CONSTRAINT [DF_Parameter_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[QualityFlag] ADD  CONSTRAINT [DF_QualityFlag_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[QualityFlag] ADD  CONSTRAINT [DF_QualityFlag_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[QualityFlag] ADD  CONSTRAINT [DF_QualityFlag_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[QualityFlag] ADD  CONSTRAINT [DF_QualityFlag_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[SampleFrequency] ADD  CONSTRAINT [DF_SampleFrequency_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[SampleFrequency] ADD  CONSTRAINT [DF_SampleFrequency_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[SampleFrequency] ADD  CONSTRAINT [DF_SampleFrequency_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[SampleFrequency] ADD  CONSTRAINT [DF_SampleFrequency_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[SiteData] ADD  CONSTRAINT [DF_SiteData_CommunityProjectName]  DEFAULT (N'Napa') FOR [CommunityProjectName]
GO
ALTER TABLE [stream].[SiteData] ADD  CONSTRAINT [DF_SiteData_userId]  DEFAULT ((9)) FOR [userId]
GO
ALTER TABLE [stream].[SiteLocation] ADD  CONSTRAINT [DF_SiteLocation_CARBAssignedSiteCode]  DEFAULT ('Unassigned '+CONVERT([nvarchar](36),newid())) FOR [CARBSiteCode]
GO
ALTER TABLE [stream].[SiteLocation] ADD  CONSTRAINT [DF_SiteLocation_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[SiteLocation] ADD  CONSTRAINT [DF_SiteLocation_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[SiteLocation] ADD  CONSTRAINT [DF_SiteLocation_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[SiteLocation] ADD  CONSTRAINT [DF_SiteLocation_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[SiteLocationHistory] ADD  CONSTRAINT [DF_SiteLocationHistory_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
ALTER TABLE [stream].[SiteLocationHistory] ADD  CONSTRAINT [DF_SiteLocationHistory_ApprovedDate]  DEFAULT (getdate()) FOR [ApprovedDate]
GO
ALTER TABLE [stream].[SiteLocationHistory] ADD  CONSTRAINT [DF_SiteLocationHistory_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[SiteLocationHistory] ADD  CONSTRAINT [DF_SiteLocationHistory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[SiteLocationHistory] ADD  CONSTRAINT [DF_SiteLocationHistory_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[SiteLocationHistory] ADD  CONSTRAINT [DF_SiteLocationHistory_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[SiteMonitor] ADD  CONSTRAINT [DF_SiteMonitor_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[SiteMonitor] ADD  CONSTRAINT [DF_SiteMonitor_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[SiteMonitor] ADD  CONSTRAINT [DF_SiteMonitor_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[SiteMonitor] ADD  CONSTRAINT [DF_SiteMonitor_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[SiteMonitorHistory] ADD  CONSTRAINT [DF_SiteMonitorHistory_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
ALTER TABLE [stream].[SiteMonitorHistory] ADD  CONSTRAINT [DF_SiteMonitorHistory_ApprovedDate]  DEFAULT (getdate()) FOR [ApprovedDate]
GO
ALTER TABLE [stream].[SiteMonitorHistory] ADD  CONSTRAINT [DF_SiteMonitorHistory_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[SiteMonitorHistory] ADD  CONSTRAINT [DF_SiteMonitorHistory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[SiteMonitorHistory] ADD  CONSTRAINT [DF_SiteMonitorHistory_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[SiteMonitorHistory] ADD  CONSTRAINT [DF_SiteMonitorHistory_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[SiteMonitorParameter] ADD  CONSTRAINT [DF_SiteMonitorParameterr_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[SiteMonitorParameter] ADD  CONSTRAINT [DFSiteMonitorParameter_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[SiteMonitorParameter] ADD  CONSTRAINT [DF_SiteMonitorParameter_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[SiteMonitorParameter] ADD  CONSTRAINT [DF_SiteMonitorParameter_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [stream].[UserDataProvider] ADD  CONSTRAINT [DF_UserDataProvider_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [stream].[UserDataProvider] ADD  CONSTRAINT [DF_UserDataProvider_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [stream].[UserDataProvider] ADD  CONSTRAINT [DF_UserDataProvider_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [stream].[UserDataProvider] ADD  CONSTRAINT [DF_UserDataProvider_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[AuditTracking] ADD  CONSTRAINT [DF_AuditTracking_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[Community] ADD  CONSTRAINT [DF_Community_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[Community] ADD  CONSTRAINT [DF_Community_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[Community] ADD  CONSTRAINT [DF_Community_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[Community] ADD  CONSTRAINT [DF_Community_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[DataFile] ADD  CONSTRAINT [DF_DataFile_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[DataFile] ADD  CONSTRAINT [DF_DataFile_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[DataFile] ADD  CONSTRAINT [DF_DataFile_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[DataFile] ADD  CONSTRAINT [DF_DataFile_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[DataFileArchive] ADD  CONSTRAINT [DF_DataFileArchive_ArchivedDate]  DEFAULT (getdate()) FOR [ArchivedDate]
GO
ALTER TABLE [temp_stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[DataProvider] ADD  CONSTRAINT [DF_DataProvider_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[Instrument] ADD  CONSTRAINT [DF_Instrument_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[Instrument] ADD  CONSTRAINT [DF_Instrument_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[Instrument] ADD  CONSTRAINT [DF_Instrument_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[Instrument] ADD  CONSTRAINT [DF_Instrument_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[MonitorPurpose] ADD  CONSTRAINT [DF_MonitorPurpose_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[MonitorStaging] ADD  CONSTRAINT [DF_MonitorStaging_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[MonitorStaging] ADD  CONSTRAINT [DF_MonitorStaging_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[MonitorStaging] ADD  CONSTRAINT [DF_MonitorStaging_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[MonitorStaging] ADD  CONSTRAINT [DF_MonitorStaging_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[Parameter] ADD  CONSTRAINT [DF_Parameter_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[Parameter] ADD  CONSTRAINT [DF_User_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[Parameter] ADD  CONSTRAINT [DF_Parameter_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[Parameter] ADD  CONSTRAINT [DF_Parameter_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[SampleDuration] ADD  CONSTRAINT [DF_SampleDuration_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[SampleQualityCode] ADD  CONSTRAINT [DF_SampleQualityCode_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[SampleQualityCode] ADD  CONSTRAINT [DF_SampleQualityCode_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[SampleQualityCode] ADD  CONSTRAINT [DF_SampleQualityCode_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[SampleQualityCode] ADD  CONSTRAINT [DF_SampleQualityCode_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[SampleUnit] ADD  CONSTRAINT [DF_SampleUnit_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[SampleUnit] ADD  CONSTRAINT [DF_SampleUnit_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[SampleUnit] ADD  CONSTRAINT [DF_SampleUnit_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[SampleUnit] ADD  CONSTRAINT [DF_SampleUnit_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[SensorStreamData] ADD  CONSTRAINT [DF_SensorVendorStreamData_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[SensorStreamData] ADD  CONSTRAINT [DF_SensorVendorStreamData_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[SensorStreamData] ADD  CONSTRAINT [DF_SensorVendorStreamData_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[SensorStreamData] ADD  CONSTRAINT [DF_SensorVendorStreamData_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[SetupMetadata] ADD  CONSTRAINT [DF_SetupAndMetadata_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[SetupMetadata] ADD  CONSTRAINT [DF_SetupAndMetadata_SubmittedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[SetupMetadata] ADD  CONSTRAINT [DF_SetupAndMetadata_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[SetupMetadata] ADD  CONSTRAINT [DF_SetupAndMetadata_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[TimeSeriesStaging] ADD  CONSTRAINT [DF_TimeSeriesStaging_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[TimeSeriesStaging] ADD  CONSTRAINT [DF_TimeSeriesStaging_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[TimeSeriesStaging] ADD  CONSTRAINT [DF_TimeSeriesStaging_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[TimeSeriesStaging] ADD  CONSTRAINT [DF_TimeSeriesStaging_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [temp_stream].[TransactionType] ADD  CONSTRAINT [DF_TransactionType_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO
ALTER TABLE [temp_stream].[TransactionType] ADD  CONSTRAINT [DF_TransactionType_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [temp_stream].[TransactionType] ADD  CONSTRAINT [DF_TransactionType_UpdatedBy]  DEFAULT ((-1)) FOR [UpdatedBy]
GO
ALTER TABLE [temp_stream].[TransactionType] ADD  CONSTRAINT [DF_TransactionType_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [account].[ActivityLog]  WITH CHECK ADD  CONSTRAINT [FK_ActivityLog_User_UserId] FOREIGN KEY([UserId])
REFERENCES [account].[User] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[ActivityLog] CHECK CONSTRAINT [FK_ActivityLog_User_UserId]
GO
ALTER TABLE [account].[Notification]  WITH CHECK ADD  CONSTRAINT [FK_Notification_User_UserId] FOREIGN KEY([UserId])
REFERENCES [account].[User] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[Notification] CHECK CONSTRAINT [FK_Notification_User_UserId]
GO
ALTER TABLE [account].[Privilege]  WITH CHECK ADD  CONSTRAINT [FK_Privilege_User_UserId] FOREIGN KEY([UserId])
REFERENCES [account].[User] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[Privilege] CHECK CONSTRAINT [FK_Privilege_User_UserId]
GO
ALTER TABLE [account].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_AccessLevel_AccessLevelId] FOREIGN KEY([AccessLevelId])
REFERENCES [account].[AccessLevel] ([AccessLevelId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[User] CHECK CONSTRAINT [FK_User_AccessLevel_AccessLevelId]
GO
ALTER TABLE [account].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_AirDistrict_AirDistrictId] FOREIGN KEY([AirDistrictId])
REFERENCES [account].[AirDistrict] ([AirDistrictId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[User] CHECK CONSTRAINT [FK_User_AirDistrict_AirDistrictId]
GO
ALTER TABLE [account].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_CarbDivision_CarbDivisionId] FOREIGN KEY([CarbDivisionId])
REFERENCES [account].[CarbDivision] ([CarbDivisionId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[User] CHECK CONSTRAINT [FK_User_CarbDivision_CarbDivisionId]
GO
ALTER TABLE [account].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_PhoneType_PhoneType] FOREIGN KEY([PhoneTypeId])
REFERENCES [account].[PhoneType] ([PhoneTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[User] CHECK CONSTRAINT [FK_User_PhoneType_PhoneType]
GO
ALTER TABLE [account].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_UserRoleId] FOREIGN KEY([RoleId])
REFERENCES [account].[Role] ([RoleId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[User] CHECK CONSTRAINT [FK_User_Role_UserRoleId]
GO
ALTER TABLE [account].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserType_UserTypeId] FOREIGN KEY([UserTypeId])
REFERENCES [account].[UserType] ([UserTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[User] CHECK CONSTRAINT [FK_User_UserType_UserTypeId]
GO
ALTER TABLE [account].[UserDocument]  WITH CHECK ADD  CONSTRAINT [FK_UserDocument_User_UserId] FOREIGN KEY([UserId])
REFERENCES [account].[User] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [account].[UserDocument] CHECK CONSTRAINT [FK_UserDocument_User_UserId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [report].[ReportFile]  WITH CHECK ADD  CONSTRAINT [FK_ReportFile_ReportFileTypeId] FOREIGN KEY([ReportFileTypeId])
REFERENCES [report].[ReportFileType] ([ReportFileTypeId])
GO
ALTER TABLE [report].[ReportFile] CHECK CONSTRAINT [FK_ReportFile_ReportFileTypeId]
GO
ALTER TABLE [stream].[AdjustmentTechnique]  WITH CHECK ADD  CONSTRAINT [FK_AdjustmentTechnique_DataProviderId] FOREIGN KEY([DataProviderId])
REFERENCES [stream].[DataProvider] ([DataProviderId])
GO
ALTER TABLE [stream].[AdjustmentTechnique] CHECK CONSTRAINT [FK_AdjustmentTechnique_DataProviderId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite]  WITH CHECK ADD  CONSTRAINT [FK_AirMonitoringStreamSite_DetectionRangeUnitId] FOREIGN KEY([DetectionRangeUnitId])
REFERENCES [stream].[MeasurementUnit] ([MeasurementUnitId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] CHECK CONSTRAINT [FK_AirMonitoringStreamSite_DetectionRangeUnitId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite]  WITH CHECK ADD  CONSTRAINT [FK_AirMonitoringStreamSite_MeasurementTechniqueId] FOREIGN KEY([MeasurementTechniqueId])
REFERENCES [stream].[MeasurementTechnique] ([MeasurementTechniqueId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] CHECK CONSTRAINT [FK_AirMonitoringStreamSite_MeasurementTechniqueId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite]  WITH CHECK ADD  CONSTRAINT [FK_AirMonitoringStreamSite_ParameterId] FOREIGN KEY([ParameterId])
REFERENCES [stream].[Parameter] ([ParameterId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] CHECK CONSTRAINT [FK_AirMonitoringStreamSite_ParameterId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite]  WITH CHECK ADD  CONSTRAINT [FK_AirMonitoringStreamSite_SampleDurationId] FOREIGN KEY([SampleDurationId])
REFERENCES [stream].[SampleDuration] ([SampleDurationId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] CHECK CONSTRAINT [FK_AirMonitoringStreamSite_SampleDurationId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite]  WITH CHECK ADD  CONSTRAINT [FK_AirMonitoringStreamSite_SampleFrequencyId] FOREIGN KEY([SampleFrequencyId])
REFERENCES [stream].[SampleFrequency] ([SampleFrequencyId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] CHECK CONSTRAINT [FK_AirMonitoringStreamSite_SampleFrequencyId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite]  WITH CHECK ADD  CONSTRAINT [FK_AirMonitoringStreamSite_SiteMonitorId] FOREIGN KEY([SiteMonitorId])
REFERENCES [stream].[SiteMonitor] ([SiteMonitorId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] CHECK CONSTRAINT [FK_AirMonitoringStreamSite_SiteMonitorId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSite]  WITH CHECK ADD  CONSTRAINT [FK_SiteMonitoParameter_SampleUnitId] FOREIGN KEY([MeasurementUnitId])
REFERENCES [stream].[MeasurementUnit] ([MeasurementUnitId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSite] CHECK CONSTRAINT [FK_SiteMonitoParameter_SampleUnitId]
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory]  WITH CHECK ADD  CONSTRAINT [FK_AirMonitoringStreamSiteHistory_AirMonitoringStreamSiteId] FOREIGN KEY([AirMonitoringStreamSiteId])
REFERENCES [stream].[AirMonitoringStreamSite] ([AirMonitoringStreamSiteId])
GO
ALTER TABLE [stream].[AirMonitoringStreamSiteHistory] CHECK CONSTRAINT [FK_AirMonitoringStreamSiteHistory_AirMonitoringStreamSiteId]
GO
ALTER TABLE [stream].[Community]  WITH CHECK ADD  CONSTRAINT [FK_Community_DataProviderId] FOREIGN KEY([DataProviderId])
REFERENCES [stream].[DataProvider] ([DataProviderId])
GO
ALTER TABLE [stream].[Community] CHECK CONSTRAINT [FK_Community_DataProviderId]
GO
ALTER TABLE [stream].[MeasurementFile]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementFile_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MeasurementFile] CHECK CONSTRAINT [FK_MeasurementFile_User_CreatedBy]
GO
ALTER TABLE [stream].[MeasurementFile]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementFile_User_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MeasurementFile] CHECK CONSTRAINT [FK_MeasurementFile_User_UpdatedBy]
GO
ALTER TABLE [stream].[MeasurementStaging]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStaging_MeasurementFileId] FOREIGN KEY([MeasurementFileId])
REFERENCES [stream].[MeasurementFile] ([MeasurementFileId])
GO
ALTER TABLE [stream].[MeasurementStaging] CHECK CONSTRAINT [FK_MeasurementStaging_MeasurementFileId]
GO
ALTER TABLE [stream].[MeasurementStaging]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStaging_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MeasurementStaging] CHECK CONSTRAINT [FK_MeasurementStaging_User_CreatedBy]
GO
ALTER TABLE [stream].[MeasurementStaging]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStaging_User_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MeasurementStaging] CHECK CONSTRAINT [FK_MeasurementStaging_User_UpdatedBy]
GO
ALTER TABLE [stream].[MeasurementStagingArchive]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStagingArchive_MeasurementFileId] FOREIGN KEY([MeasurementFileId])
REFERENCES [stream].[MeasurementFileArchive] ([MeasurementFileId])
GO
ALTER TABLE [stream].[MeasurementStagingArchive] CHECK CONSTRAINT [FK_MeasurementStagingArchive_MeasurementFileId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_AdjustmentTechniqueId] FOREIGN KEY([AdjustmentTechniqueId])
REFERENCES [stream].[AdjustmentTechnique] ([AdjustmentTechniqueId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_AdjustmentTechniqueId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_AirMonitoringStreamSiteId] FOREIGN KEY([AirMonitoringStreamSiteId])
REFERENCES [stream].[AirMonitoringStreamSite] ([AirMonitoringStreamSiteId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_AirMonitoringStreamSiteId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_DetectionRangeUnitId] FOREIGN KEY([DetectionRangeUnitId])
REFERENCES [stream].[MeasurementUnit] ([MeasurementUnitId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_DetectionRangeUnitId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_LabOrganizationId] FOREIGN KEY([LabOrganizationId])
REFERENCES [stream].[LabOrganization] ([LabOrganizationId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_LabOrganizationId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_MeasurementFileId] FOREIGN KEY([MeasurementFileId])
REFERENCES [stream].[MeasurementFile] ([MeasurementFileId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_MeasurementFileId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_MeasurementHourId] FOREIGN KEY([MeasurementHourId])
REFERENCES [stream].[MeasurementHour] ([MeasurementHourId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_MeasurementHourId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_MeasurementUnitId] FOREIGN KEY([MeasurementUnitId])
REFERENCES [stream].[MeasurementUnit] ([MeasurementUnitId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_MeasurementUnitId]
GO
ALTER TABLE [stream].[MeasurementStreamData]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementStreamData_QualityFlagId] FOREIGN KEY([QualityFlagId])
REFERENCES [stream].[QualityFlag] ([QualityFlagId])
GO
ALTER TABLE [stream].[MeasurementStreamData] CHECK CONSTRAINT [FK_MeasurementStreamData_QualityFlagId]
GO
ALTER TABLE [stream].[MeasurementTechnique]  WITH CHECK ADD  CONSTRAINT [FK_MeasurementTechnique_ParameterId] FOREIGN KEY([ParameterId])
REFERENCES [stream].[Parameter] ([ParameterId])
GO
ALTER TABLE [stream].[MeasurementTechnique] CHECK CONSTRAINT [FK_MeasurementTechnique_ParameterId]
GO
ALTER TABLE [stream].[MetadataFile]  WITH CHECK ADD  CONSTRAINT [FK_MetadataFile_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MetadataFile] CHECK CONSTRAINT [FK_MetadataFile_User_CreatedBy]
GO
ALTER TABLE [stream].[MetadataFile]  WITH CHECK ADD  CONSTRAINT [FK_MetadataFile_User_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MetadataFile] CHECK CONSTRAINT [FK_MetadataFile_User_UpdatedBy]
GO
ALTER TABLE [stream].[MetadataStaging]  WITH CHECK ADD  CONSTRAINT [FK_MetadataStaging_DataFileMetadataId] FOREIGN KEY([MetadataFileId])
REFERENCES [stream].[MetadataFile] ([MetadataFileId])
GO
ALTER TABLE [stream].[MetadataStaging] CHECK CONSTRAINT [FK_MetadataStaging_DataFileMetadataId]
GO
ALTER TABLE [stream].[MetadataStaging]  WITH CHECK ADD  CONSTRAINT [FK_MetadataStaging_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MetadataStaging] CHECK CONSTRAINT [FK_MetadataStaging_User_CreatedBy]
GO
ALTER TABLE [stream].[MetadataStaging]  WITH CHECK ADD  CONSTRAINT [FK_MetadataStaging_User_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[MetadataStaging] CHECK CONSTRAINT [FK_MetadataStaging_User_UpdatedBy]
GO
ALTER TABLE [stream].[MetadataStagingArchive]  WITH CHECK ADD  CONSTRAINT [FK_MetadataStagingArchive_DataFileMetadataId] FOREIGN KEY([MetadataFileId])
REFERENCES [stream].[MetadataFileArchive] ([MetadataFileId])
GO
ALTER TABLE [stream].[MetadataStagingArchive] CHECK CONSTRAINT [FK_MetadataStagingArchive_DataFileMetadataId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameter]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameter_MonitorMfrModelId] FOREIGN KEY([MonitorMfrModelId])
REFERENCES [stream].[MonitorMfrModel] ([MonitorMfrModelId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameter] CHECK CONSTRAINT [FK_MonitorMfrModelParameter_MonitorMfrModelId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameter]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameter_ParameterId] FOREIGN KEY([ParameterId])
REFERENCES [stream].[Parameter] ([ParameterId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameter] CHECK CONSTRAINT [FK_MonitorMfrModelParameter_ParameterId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameterDetails_DetectionRangeUnitId] FOREIGN KEY([DetectionRangeUnitId])
REFERENCES [stream].[MeasurementUnit] ([MeasurementUnitId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] CHECK CONSTRAINT [FK_MonitorMfrModelParameterDetails_DetectionRangeUnitId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameterDetails_MeasurementTechniqueId] FOREIGN KEY([MeasurementTechniqueId])
REFERENCES [stream].[MeasurementTechnique] ([MeasurementTechniqueId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] CHECK CONSTRAINT [FK_MonitorMfrModelParameterDetails_MeasurementTechniqueId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameterDetails_MeasurementUnitId] FOREIGN KEY([MeasurementUnitId])
REFERENCES [stream].[MeasurementUnit] ([MeasurementUnitId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] CHECK CONSTRAINT [FK_MonitorMfrModelParameterDetails_MeasurementUnitId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameterDetails_MonitorMfrModelParameterId] FOREIGN KEY([MonitorMfrModelParameterId])
REFERENCES [stream].[MonitorMfrModelParameter] ([MonitorMfrModelParameterId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] CHECK CONSTRAINT [FK_MonitorMfrModelParameterDetails_MonitorMfrModelParameterId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameterDetails_SampleDurationId] FOREIGN KEY([SampleDurationId])
REFERENCES [stream].[SampleDuration] ([SampleDurationId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] CHECK CONSTRAINT [FK_MonitorMfrModelParameterDetails_SampleDurationId]
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails]  WITH CHECK ADD  CONSTRAINT [FK_MonitorMfrModelParameterDetails_SampleFrequencyId] FOREIGN KEY([SampleFrequencyId])
REFERENCES [stream].[SampleFrequency] ([SampleFrequencyId])
GO
ALTER TABLE [stream].[MonitorMfrModelParameterDetails] CHECK CONSTRAINT [FK_MonitorMfrModelParameterDetails_SampleFrequencyId]
GO
ALTER TABLE [stream].[QualityFlag]  WITH CHECK ADD  CONSTRAINT [FK_QualityFlag_DataProviderId] FOREIGN KEY([DataProviderId])
REFERENCES [stream].[DataProvider] ([DataProviderId])
GO
ALTER TABLE [stream].[QualityFlag] CHECK CONSTRAINT [FK_QualityFlag_DataProviderId]
GO
ALTER TABLE [stream].[SiteLocation]  WITH CHECK ADD  CONSTRAINT [FK_SiteLocation_CommunityId] FOREIGN KEY([CommunityId])
REFERENCES [stream].[Community] ([CommunityId])
GO
ALTER TABLE [stream].[SiteLocation] CHECK CONSTRAINT [FK_SiteLocation_CommunityId]
GO
ALTER TABLE [stream].[SiteLocationHistory]  WITH CHECK ADD  CONSTRAINT [FK_SiteLocationHistory_SiteLocationId] FOREIGN KEY([SiteLocationId])
REFERENCES [stream].[SiteLocation] ([SiteLocationId])
GO
ALTER TABLE [stream].[SiteLocationHistory] CHECK CONSTRAINT [FK_SiteLocationHistory_SiteLocationId]
GO
ALTER TABLE [stream].[SiteMonitor]  WITH CHECK ADD  CONSTRAINT [FK_SiteMonitor_MonitorMfrModelId] FOREIGN KEY([MonitorMfrModelId])
REFERENCES [stream].[MonitorMfrModel] ([MonitorMfrModelId])
GO
ALTER TABLE [stream].[SiteMonitor] CHECK CONSTRAINT [FK_SiteMonitor_MonitorMfrModelId]
GO
ALTER TABLE [stream].[SiteMonitor]  WITH CHECK ADD  CONSTRAINT [FK_SiteMonitor_MonitorPurposeId] FOREIGN KEY([MonitorPurposeId])
REFERENCES [stream].[MonitorPurpose] ([MonitorPurposeId])
GO
ALTER TABLE [stream].[SiteMonitor] CHECK CONSTRAINT [FK_SiteMonitor_MonitorPurposeId]
GO
ALTER TABLE [stream].[SiteMonitor]  WITH CHECK ADD  CONSTRAINT [FK_SiteMonitor_SiteLocationId] FOREIGN KEY([SiteLocationId])
REFERENCES [stream].[SiteLocation] ([SiteLocationId])
GO
ALTER TABLE [stream].[SiteMonitor] CHECK CONSTRAINT [FK_SiteMonitor_SiteLocationId]
GO
ALTER TABLE [stream].[SiteMonitorHistory]  WITH CHECK ADD  CONSTRAINT [FK_SiteMonitorHistory_SiteMonitorId] FOREIGN KEY([SiteMonitorId])
REFERENCES [stream].[SiteMonitor] ([SiteMonitorId])
GO
ALTER TABLE [stream].[SiteMonitorHistory] CHECK CONSTRAINT [FK_SiteMonitorHistory_SiteMonitorId]
GO
ALTER TABLE [stream].[UserDataProvider]  WITH CHECK ADD  CONSTRAINT [FK_UserDataProvider_DataProviderId] FOREIGN KEY([DataProviderId])
REFERENCES [stream].[DataProvider] ([DataProviderId])
GO
ALTER TABLE [stream].[UserDataProvider] CHECK CONSTRAINT [FK_UserDataProvider_DataProviderId]
GO
ALTER TABLE [stream].[UserDataProvider]  WITH CHECK ADD  CONSTRAINT [FK_UserDataProvider_UserId] FOREIGN KEY([UserId])
REFERENCES [account].[User] ([UserId])
GO
ALTER TABLE [stream].[UserDataProvider] CHECK CONSTRAINT [FK_UserDataProvider_UserId]
GO
USE [master]
GO
ALTER DATABASE [carbcaq] SET  READ_WRITE 
GO
