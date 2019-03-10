using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SensorStreamData
    {
        public long SensorStreamData1 { get; set; }
        public int SensorVendorId { get; set; }
        public int SensorId { get; set; }
        public string SensorName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int ParameterId { get; set; }
        public double? MeasurementValue { get; set; }
        public int? UpTime { get; set; }
        public double? TemperatureInFahrenheit { get; set; }
        public double? HumidityPercent { get; set; }
        public int? LastEntryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
