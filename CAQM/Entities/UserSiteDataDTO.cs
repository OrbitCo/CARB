using System;
using System.Collections.Generic;
using System.Text;

namespace CAQM.Entities
{
   public class UserSiteDataDTO
    {
        public int userId { get; set; }
        public List<UserSites> userSites { get; set; }
    }

    public class UserSites
    {
        public bool active { get; set; }
        public string communityProjectName { get; set; }
        public string siteName { get; set; }
        public string siteId { get; set; }
        public decimal? siteLatitude { get; set; }
        public decimal? siteLongitude { get; set; }
        public string siteElevation { get; set; }
        public List<SiteMonitor> siteMonitors { get; set; }
    }

    public class SiteMonitor
    {
        public string monitorId { get; set; }
        public int Parameter { get; set; }

        public DateTime ? dateStart { get; set; }
        public Boolean active { get; set; }
        public string monitorName { get; set; }
        public string monitorPurpose { get; set; }
        public string monitorManufacturer { get; set; }
        public string monitorModel { get; set; }
        public string monitorFirmwareVersion { get; set; }
        public string monitorPurchaseDate { get; set; }
        public string monitorLastServiceDate { get; set; }
        public string monitorCfrstring { get; set; }
        public string monitorFlowRate { get; set; }
        public string monitorInletHeight { get; set; }
        public string monitorInletOrientation { get; set; }
        public string monitorInletDiameter { get; set; }
        public string monitorSystemDescription { get; set; }
        public List<MonitorParameters> monitorParameters { get; set; }
    }
    public class MonitorParameters
    {
        public int parameterCode { get; set; }
        public string parameterName { get; set; }
        public bool? parameterIsActive { get; set; }
        public int? parameterMeasurementTechnique { get; set; }
        public int? parameterMeasurementUnits { get; set; }
        public int? parameterSamplingDuration { get; set; }
        public string parameterSamplingFrequency { get; set; }
        public double? parameterUpperDetectionLimit { get; set; }
        public double? parameterLowerDetectionLimit { get; set; }
        public double? parameterMethodDetectionLimit { get; set; }
        public int? parameterDetectionRangeUnits { get; set; }
        public string parameterUncertainty { get; set; }
        public string parameterPrecision { get; set; }
        public string parameterMeasurementResolution { get; set; }
        public DateTime? parameterLastCalibrationTimestamp { get; set; }
        public DateTime? parameterDateStart { get; set; }

    }
}
