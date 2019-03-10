using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class RelocateMonitorDto
    {
        public string communityName { get; set; }
        public DateTime? dateEnd { get; set; }
        public DateTime? dateStart { get; set; }
        public string explanation { get; set; }
        public string monitorCfrSiting { get; set; }
        public string monitorFirmwareVersion { get; set; }
        public string monitorFlowRate { get; set; }

        public string monitorId { get; set; }
        public string monitorInletDiameter { get; set; }
        public string monitorInletHeight { get; set; }
        public string monitorInletOrientation { get; set; }
        public string monitorLastServiceDate { get; set; }
        public string monitorManufacturer { get; set; }
        public string monitorModel { get; set; }
        public string monitorPurchaseDate { get; set; }
        public string monitorPurpose { get; set; }
        public string monitorSystemDescription { get; set; }

        public string siteId { get; set; }
        public decimal? siteLatitude { get; set; }
        public decimal? siteLongitude { get; set; }
        public string siteName { get; set; }
        public string siteElevation { get; set; }
        public string _originalSiteId { get; set; }
        public string _transactionType { get; set; }
    }
}
