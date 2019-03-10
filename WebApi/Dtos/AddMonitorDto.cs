using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class AddMonitorDto
    {
        public string monitorCfrSiting { get; set; }
        public int monitorFirmwareVersion { get; set; }
        public string monitorFlowRate { get; set; }

        [Required]

        public Boolean active { get; set; }
        public string siteId { get; set; }
        public string monitorId { get; set; }
        public string monitorInletDiameter { get; set; }
        public string monitorInletHeight { get; set; }
        public string monitorInletOrientation { get; set; }
        public DateTime monitorLastServiceDate { get; set; }
        public string monitorManufacturer { get; set; }
        public string monitorModel { get; set; }
        public DateTime monitorPurchaseDate { get; set; }
        public DateTime dateStart { get; set; }
        public string explanation { get; set; }
        public string monitorPurpose { get; set; }
        public string monitorSystemDescription { get; set; }
        public string _transactionType { get; set; }

        public List<MonitorParametersDto> monitorParameters { get; set; }
    }
    public class MonitorParametersDto
    {
        public DateTime dateStart { get; set; }
        public string parameterCode { get; set; }
        public string parameterDetectionRangeUnits { get; set; }
        public DateTime parameterLastCalibrationTimestamp { get; set; }
        public string parameterLowerDetectionLimit { get; set; }
        public string parameterMeasurementResolution { get; set; }
        public string parameterMeasurementTechnique { get; set; }
        public string parameterMeasurementUnits { get; set; }
        public string parameterMethodDetectionLimit { get; set; }
        public string parameterName { get; set; }
        public string parameterPrecision { get; set; }
        public string parameterSamplingDuration { get; set; }
        public string parameterSamplingFrequency { get; set; }
        public string parameterUncertainty { get; set; }
        public string parameterUpperDetectionLimit { get; set; }
    }
}



