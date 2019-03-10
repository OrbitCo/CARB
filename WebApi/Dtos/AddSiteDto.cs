using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class AddSiteDto
    {
        public string siteId { get; set; }
        public string _transactionType { get; set; }
        public string _addMonitorsFormStatus { get; set; }
        public List<SiteMonitors> siteMonitors { get; set; }
    }

    public class SiteMonitors
    {
        public string siteId { get; set; }
        public DateTime dateStart { get; set; }
        public string monitorId { get; set; }
        public string monitorPurpose { get; set; }
        public string monitorManufacturer { get; set; }
        public string monitorModel { get; set; }
        public string monitorFirmwareVersion { get; set; }
        public string monitorPurchaseDate { get; set; }
        public string monitorLastServiceDate { get; set; }
   
        //public string monitorCfrCiting { get; set; } //monitorCfrSiting
        public string monitorCfrSiting { get; set; } //monitorCfrSiting
        public string monitorFlowRate { get; set; }
        public string monitorInletHeight { get; set; }
        public string monitorInletOrientation { get; set; }
        public string monitorInletDiameter { get; set; }
        public string monitorSystemDescription { get; set; }

        public List<MonitorParameters> monitorParameters { get; set; }
    }
    public class MonitorParameters
    {
        public string parameterCode { get; set; }
        public string parameterName { get; set; }
        //public string monitorMeasurementTechnique { get; set; }
        //public string monitorMeasurementUnits { get; set; }
        //public string monitorSamplingDuration { get; set; }
        //public string monitorSamplingFrequency { get; set; }
        //public string monitorUpperDetectionLimit { get; set; }
        //public string monitorLowerDetectionLimit { get; set; }
        //public string monitorMethodDetectionLimit { get; set; }
        //public string monitorDetectionRangeUnits { get; set; }
        //public string monitorUncertainty { get; set; }
        //public string monitorPrecision { get; set; }
        //public string monitorMeasurementResolution { get; set; }
        //public string monitorLastCalibrationTimestamp { get; set; }

        public string parameterMeasurementTechnique { get; set; }
        public string parameterMeasurementUnits { get; set; }
        public string parameterSamplingDuration { get; set; }
        public string parameterSamplingFrequency { get; set; }
        public string parameterUpperDetectionLimit { get; set; }
        public string parameterLowerDetectionLimit { get; set; }
        public string parameterMethodDetectionLimit { get; set; }
        public string parameterDetectionRangeUnits { get; set; }
        public string parameterUncertainty { get; set; }
        public string parameterPrecision { get; set; }
        public string parameterMeasurementResolution { get; set; }
        public DateTime parameterLastCalibrationTimestamp { get; set; }
        public DateTime dateStart { get; set; }
    }
}
